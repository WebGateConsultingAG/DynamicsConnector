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
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Net.Mime;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;

namespace WebGate.Dynamics.Connector
{
    public static class HttpFunctions
    {
        public static async Task<T> GetAsync<T>(HttpClient client, string path)
        {
            T obj = default;
            HttpResponseMessage response = await client.GetAsync(path);
            
            if (response.IsSuccessStatusCode)
            {
                using Stream responseStream = await response.Content.ReadAsStreamAsync();
                return JsonConvert.DeserializeObject<T>(new StreamReader(responseStream).ReadToEnd());
            }
            else
            {
                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }
            return obj;
        }

        public static async Task<T> PostAsync<T>(HttpClient client, string path, object postData)
        {
            T obj = default;
            StringContent content = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await client.PostAsync(path, content);
            if (response.IsSuccessStatusCode)
            {
                using Stream responseStream = await response.Content.ReadAsStreamAsync();
                return JsonConvert.DeserializeObject<T>(new StreamReader(responseStream).ReadToEnd());
            }
            else {
                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }
            return obj;
        }

        public static async Task<string> CreateAsync(HttpClient client, string path, string jsonData)
        {
            string id = null;
            StringContent content = new StringContent(jsonData, Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await client.PostAsync(path, content);
            if (response.IsSuccessStatusCode)
            {
                HttpResponseHeaders headers = response.Headers;
                if (headers.TryGetValues("OData-EntityId", out IEnumerable<string> values))
                {
                    return values.First<string>().Split("(")[1].Split(")")[0];
                }
            }
            else
            {
                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }
            return id;
        }

        public static async Task<T> PatchAsync<T>(HttpClient client, string path, string jsonData)
        {
            T obj = default;
            StringContent content = new StringContent(jsonData, Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await client.PatchAsync(path, content);
            if (response.IsSuccessStatusCode)
            {
                using Stream responseStream = await response.Content.ReadAsStreamAsync();
                return JsonConvert.DeserializeObject<T>(new StreamReader(responseStream).ReadToEnd());
            }
            else {
                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }
            return obj;
        }

        public static async Task<bool> DeleteAsync<T>(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.DeleteAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else {
                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }
            return false;
        }
    }
}
