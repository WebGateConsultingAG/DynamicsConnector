/*
 * Copyright WebGate Consulting AG, 2020
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at:
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
 * implied. See the License for the specific language governing
 * permissions and limitations under the License.
 *
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebGate.Dynamics.Connector;
using WebGate.Dynamics.Model;
using WebGate.Dynamics.Util;
using System.Collections.Generic;
using static WebGate.Dynamics.Connector.DynamicsConnector;
using System.Threading.Tasks;
using System.Linq;

namespace DynamicsConnectorTest
{
    [TestClass]
    public class DynamicsIntegrationTest
    {
        public TestContext TestContext { get; set; }
        private DynamicsConnector connector;
        private string FirstNameAnswer;
        private string LastNameAnswer;


        [TestInitialize]
        public void TestInitialize() {
            string AppId = (string)TestContext.Properties["APPLICATION_ID"];
            string AppSecret = (string)TestContext.Properties["APPLICATION_SECRET"];
            string Tenant = (string)TestContext.Properties["TENANT_NAME"];
            string Resource = (string)TestContext.Properties["RESOURCE"];
            FirstNameAnswer = (string)TestContext.Properties["ANSWER_FIRSTNAME"];
            LastNameAnswer = (string)TestContext.Properties["ANSWER_LASTNAME"];
            connector = new DynamicsConnectorBuilder().
                WithApplicationId(AppId).WithApplicationSecret(AppSecret).WithResource(Resource).WithTenant(Tenant).Build();
        }


        [TestMethod]
        public void GetList()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Organization
            };
            Task<DynamicsResponse<ICollection<Organization>>> task = HttpFunctions.GetAsync<DynamicsResponse<ICollection<Organization>>>(connector.GetClient(), query.GetPath());
            DynamicsResponse<ICollection<Organization>>  answer = task.GetAwaiter().GetResult();
            Assert.IsTrue(answer != null);
            Assert.IsTrue(answer.value.Count > 0);
        }

        [TestMethod]
        public void GetFilteredList()
        {
            DynamicsQuery query = new DynamicsQuery()
            {
                Table = DynamicsTables.Systemuser,
                Filters = new List<Filter>() {
                    new Filter()
                    {
                        Field = nameof(SystemUser.firstname),
                        Operator = FilterOperator.EqualsOperator,
                        Value = FirstNameAnswer
                    },
                    new Filter{
                        Field = nameof(SystemUser.lastname),
                        Operator = FilterOperator.EqualsOperator,
                        Value = LastNameAnswer,
                        GlobalOperator = FilterOperator.Or

                    }
                }
            };

            Task<DynamicsResponse<ICollection<SystemUser>>> task = HttpFunctions.GetAsync<DynamicsResponse<ICollection<SystemUser>>>(connector.GetClient(), query.GetPath());
            DynamicsResponse<ICollection<SystemUser>> answer = task.GetAwaiter().GetResult();
            Assert.IsTrue(answer != null);
            Assert.IsTrue(answer.value.Count > 0);
            Assert.IsTrue(answer.value.First().firstname.Equals(FirstNameAnswer) && answer.value.First().lastname.Equals(LastNameAnswer));
        }

        [TestMethod]
        public void GetLimitedList()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Systemuser,
                Top = 5
            };
            Task<DynamicsResponse<ICollection<SystemUser>>> task = HttpFunctions.GetAsync<DynamicsResponse<ICollection<SystemUser>>>(connector.GetClient(), query.GetPath());
            DynamicsResponse<ICollection<SystemUser>> answer = task.GetAwaiter().GetResult();
            Assert.IsTrue(answer != null);
            Assert.IsTrue(answer.value.Count == 5);
        }

        [TestMethod]
        public void GetDataById()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Systemuser,
                Key = (string)TestContext.Properties["SYSTEMUSERID"]
            };
            Task<SystemUser> task = HttpFunctions.GetAsync<SystemUser>(connector.GetClient(), query.GetPath());
            SystemUser answer = task.GetAwaiter().GetResult();
            Assert.IsTrue(answer != null);
            Assert.IsTrue(answer.firstname.Equals(FirstNameAnswer));
        }

        [TestMethod]
        public void GetDataByIdAndExpand()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Contact,
                Key = (string)TestContext.Properties["CONTACTID"],
                Fields = new List<string>() {
                    nameof(Contact.firstname)
                },
                Expand = new DynamicsQuery
                {
                    Key = nameof(Contact.owninguser),
                    Fields = new List<string>() {
                        nameof(SystemUser.firstname)
                    }
                }
            };            
            Task<Contact> task = HttpFunctions.GetAsync<Contact>(connector.GetClient(), query.GetPath());
            Contact answer = task.GetAwaiter().GetResult();         
            Assert.IsTrue(answer != null);
            Assert.IsTrue(answer.firstname.Equals(FirstNameAnswer));
            Assert.IsTrue(answer.owninguser.firstname.Equals(FirstNameAnswer));
        }
    }
}
