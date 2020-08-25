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
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace WGCDynamics
{
    public class DynamicsConnector
    {
        private static readonly string APIPATH = "/api/data/v9.0/";
        private readonly string resource;
        private readonly string tenant;
        private readonly string applicationSecret;
        private readonly string applicationId;
        private readonly HttpClient client;
        private DynamicsConnector(DynamicsConnectorBuilder builder) {
            resource = builder.Resource;
            tenant = builder.Tenant;
            applicationSecret = builder.ApplicationSecret;
            applicationId = builder.ApplicationId;
            client = new HttpClient { BaseAddress = new Uri(resource + APIPATH) };
            ReciveToken().GetAwaiter().GetResult();
        }

        public async Task<bool> ReciveToken()
        {
            ClientCredential credentials = new ClientCredential(applicationId, applicationSecret);
            var authContext = new AuthenticationContext(tenant);
            var result = await authContext.AcquireTokenAsync(resource, credentials);
            string token = result.AccessToken;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return true;
        }

        /// <summary>
        /// full functionaly dynamics client. 
        /// </summary>
        /// <returns>the client for usa</returns>
        public HttpClient GetClient() {
            return client;
        }

        /// <summary>
        /// Builder for the Dynamics Connector
        /// </summary>
        public class DynamicsConnectorBuilder
        {
            public string Resource { get; set; }
            public string ApplicationId { get; set; }
            public string Tenant { get; set; }
            public string ApplicationSecret { get; set; }

            /// <summary>
            /// Set the Url to your Dynamics Instance
            /// </summary>
            /// <param name="resource">e.g. https://yourInstanceName.crm.dynamics.com</param>
            public DynamicsConnectorBuilder WithResource(string resource)
            {
                Resource = resource;
                return this;
            }
            /// <summary>
            /// Set the Dynamics Application id
            /// </summary>
            /// <param name="applicationId">e.g.: aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee</param>
            public DynamicsConnectorBuilder WithApplicationId(string applicationId) {
                ApplicationId = applicationId;
                return this;
            }

            /// <summary>
            /// Set the Login Page for your Dynamics
            /// </summary>
            /// <param name="tenant">e.g.https://login.windows.net/yourdomain.com </param>
            public DynamicsConnectorBuilder WithTenant(string tenant) {
                Tenant = tenant;
                return this;
            }

            /// <summary>
            /// Set the App Secret
            /// </summary>
            /// <param name="appSecret"></param>
            /// <returns></returns>
            public DynamicsConnectorBuilder WithApplicationSecret(string appSecret) {
                ApplicationSecret = appSecret;
                return this;
            }
            /// <summary>
            /// Finaly build the Dynamics Connector
            /// </summary>
            /// <returns></returns>
            public DynamicsConnector Build() {
                return new DynamicsConnector(this);
            }
        }
    }
}
