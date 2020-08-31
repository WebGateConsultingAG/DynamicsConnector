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
using WGCDynamics;
using WGCDynamics.model;
using static WGCDynamics.DynamicsConnector;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace DynamicsConnectorTest
{
    [TestClass]
    public class DynamicsCrudTest
    {
        public TestContext TestContext { get; set; }
        private DynamicsConnector connector;
        private string SystemUserId;


        [TestInitialize]
        public void TestInitialize() {
            string AppId = (string)TestContext.Properties["APPLICATION_ID"];
            string AppSecret = (string)TestContext.Properties["APPLICATION_SECRET"];
            string Tenant = (string)TestContext.Properties["TENANT_NAME"];
            string Resource = (string)TestContext.Properties["RESOURCE"];
            SystemUserId = (string)TestContext.Properties["SYSTEM_USERID"];
            connector = new DynamicsConnectorBuilder().
                WithApplicationId(AppId).WithApplicationSecret(AppSecret).WithResource(Resource).WithTenant(Tenant).Build();
        }

        [TestMethod]
        public void CrudAccount()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Account
            };
            JObject account = JObject.FromObject(new Account()
            {
                name = "CrudTest üהצ"
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore });
            account["ownerid@odata.bind"] = "/systemusers("+ SystemUserId + ")";
            Task <string> task = HttpFunctions.CreateAsync(connector.GetClient(), query.GetPath(), JsonConvert.SerializeObject(account));
            string answer = task.GetAwaiter().GetResult();
            Assert.IsTrue(answer != null);
            query.Key = answer;        
            Task<bool> task2 = HttpFunctions.DeleteAsync<bool>(connector.GetClient(), query.GetPath());
            bool boolAnswer = task2.GetAwaiter().GetResult();
            Assert.IsTrue(boolAnswer);
        }
    }
}
