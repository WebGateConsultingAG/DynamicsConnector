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

namespace WGCDynamics
{
    public class HTTPFunctions
    {
        public static async Task<T> GetAsync<T>(HttpClient client, string path)
        {
            T obj = default;
            HttpResponseMessage response = await client.GetAsync(path);
            
            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                using Stream responseStream = await response.Content.ReadAsStreamAsync();
                return JsonConvert.DeserializeObject<T>(new StreamReader(responseStream).ReadToEnd());
            }
            else
            {
                Console.WriteLine(response);
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
            return obj;
        }

        public static async Task<T> PatchAsync<T>(HttpClient client, string path, object patchData)
        {
            T obj = default;
            StringContent content = new StringContent(JsonConvert.SerializeObject(patchData), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await client.PatchAsync(path, content);
            if (response.IsSuccessStatusCode)
            {
                using Stream responseStream = await response.Content.ReadAsStreamAsync();
                return JsonConvert.DeserializeObject<T>(new StreamReader(responseStream).ReadToEnd());
            }
            return obj;
        }
    }
}
