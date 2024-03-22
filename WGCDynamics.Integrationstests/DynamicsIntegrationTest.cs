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
        public async System.Threading.Tasks.Task GetList()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Organization
            };
            IEnumerable<Organization> organisations = await connector.GetAllAsync<Organization>(query);
            Assert.IsTrue(organisations != null);
            Assert.IsTrue(organisations.ToList().Count > 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetFilteredList()
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
            IEnumerable<SystemUser> allUsersFound = await connector.GetAllAsync<SystemUser>(query);
            Assert.IsTrue(allUsersFound != null);
            var allUserList = allUsersFound.ToList();
            Assert.IsTrue(allUserList.Count > 0);
            Assert.IsTrue(allUserList.First().firstname.Equals(FirstNameAnswer) && allUserList.First().lastname.Equals(LastNameAnswer));
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetLimitedList()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Systemuser,
                Top = 5
            };
            IEnumerable<SystemUser> fiveUsersFound = await connector.GetAllAsync<SystemUser>(query);
            Assert.IsTrue(fiveUsersFound != null);
            Assert.IsTrue(fiveUsersFound.ToList().Count == 5);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetDataById()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Systemuser,
                Key = (string)TestContext.Properties["SYSTEMUSERID"]
            };
            var systemUser = await connector.GetAsync<SystemUser>(query);
            Assert.IsTrue(systemUser != null);
            Assert.IsTrue(systemUser.firstname.Equals(FirstNameAnswer));
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetDataByIdAndExpand()
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
            var contact = await connector.GetAsync<Contact>(query);            
            Assert.IsTrue(contact != null);
            Assert.IsTrue(contact.firstname.Equals(FirstNameAnswer));
            Assert.IsTrue(contact.owninguser.firstname.Equals(FirstNameAnswer));
        }
    }
}
