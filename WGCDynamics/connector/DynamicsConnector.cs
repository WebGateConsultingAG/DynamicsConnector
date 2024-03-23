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
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using WebGate.Dynamics.Util;

namespace WebGate.Dynamics.Connector;
public class DynamicsConnector
{
    public static readonly string MEDIAJSON = "application/json";
    private readonly string _resource;
    private readonly HttpClient _client;
    private readonly IConfidentialClientApplication _clientAuthApp;
    private DateTimeOffset _tokenExpiresOn = DateTimeOffset.UtcNow.AddDays(-1);
    private string _token;
    public DynamicsConnector(DynamicsConnectorBuilder builder)
    {
        _resource = builder.Resource;
        string authority = $"https://login.microsoftonline.com/{builder.Tenant}";
        _clientAuthApp = ConfidentialClientApplicationBuilder.Create(builder.ApplicationId).WithClientSecret(builder.ApplicationSecret).WithAuthority(authority).Build();
        _client = new HttpClient { BaseAddress = new Uri(_resource + builder.ApiPath) };
    }

    public async Task<bool> ReciveToken()
    {
        var authResult = await _clientAuthApp.AcquireTokenForClient(new[] { $"{_resource}/.default" }).ExecuteAsync().ConfigureAwait(false);
        string token = authResult.AccessToken;
        _tokenExpiresOn = authResult.ExpiresOn;
        _token = token;
        return true;
    }



    /// <summary>
    /// full functionaly dynamics client. 
    /// </summary>
    /// <returns>the client for usa</returns>
    public async Task<HttpClient> GetClientAsync()
    {
        if (DateTimeOffset.UtcNow > _tokenExpiresOn)
        {
            await this.ReciveToken();
        }
        return _client;
    }

    public async Task<IEnumerable<T>> GetAllAsync<T>(DynamicsQuery query)
    {
        return await GetAllAsync<T>(query.GetPath());
    }
    public async Task<IEnumerable<T>> GetAllAsync<T>(string path)
    {
        IEnumerable<T> result = new List<T>();
        string pathToProcess = path;
        while (pathToProcess != null)
        {
            DynamicsListResponse<List<T>> response = await GetAsync<DynamicsListResponse<List<T>>>(pathToProcess);
            pathToProcess = null;
            if (response != null)
            {
                result = result.Concat(response.value);
                if (!string.IsNullOrEmpty(response.NextLink))
                {
                    pathToProcess = response.NextLink;
                }
            }
        }
        return result;
    }
    public async Task<T> GetAsync<T>(DynamicsQuery query)
    {
        return await GetAsync<T>(query.GetPath());
    }

    public async Task<T> GetAsync<T>(string path)
    {
        HttpClient client = await GetClientAsync();
        using HttpRequestMessage request = new(HttpMethod.Get, path);
        InjectToken(request);
        using HttpResponseMessage response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            return await BuildResultObject<T>(response);
        }
        else
        {
            throw await BuildExcpetion("GET", path, response, "");
        }
    }

    private void InjectToken(HttpRequestMessage request)
    {
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
    }

    public async Task<T> PostAsync<T>(DynamicsQuery query, object postData)
    {
        return await PostAsync<T>(query.GetPath(), postData);
    }
    public async Task<T> PostAsync<T>(string path, object postData)
    {
        string payload = JsonConvert.SerializeObject(postData, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        StringContent content = new StringContent(payload, Encoding.UTF8, MEDIAJSON);
        HttpClient client = await GetClientAsync();
        using HttpRequestMessage request = new(HttpMethod.Post, path);
        InjectToken(request);
        request.Content = content;
        using HttpResponseMessage response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            return await BuildResultObject<T>(response);
        }
        else
        {
            throw await BuildExcpetion("POST", path, response, payload);
        }
    }
    public async Task<string> CreateAsync(DynamicsQuery query, object postData)
    {
        return await CreateAsync(query.GetPath(), postData);
    }
    public async Task<string> CreateAsync(string path, object postData)
    {
        string payload = JsonConvert.SerializeObject(postData, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

        StringContent content = new StringContent(payload, Encoding.UTF8, MEDIAJSON);
        HttpClient client = await GetClientAsync();
        using HttpRequestMessage request = new(HttpMethod.Post, path);
        InjectToken(request);
        request.Content = content;
        using HttpResponseMessage response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            HttpResponseHeaders headers = response.Headers;
            if (headers.TryGetValues("OData-EntityId", out IEnumerable<string> values))
            {
                return values.First<string>().Split('(')[1].Split(')')[0];
            }
            return null;
        }
        else
        {
            throw await BuildExcpetion("POST", path, response, payload);
        }
    }
    public async Task<T> PatchAsync<T>(DynamicsQuery query, object postData)
    {
        return await PatchAsync<T>(query.GetPath(), postData);
    }
    public async Task<T> PatchAsync<T>(string path, object postData)
    {
        string payload = JsonConvert.SerializeObject(postData, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include });

        return await this.PatchAsync<T>(path, payload);

    }
    public async Task<T> PatchAsync<T>(string path, string jsonPayload)
    {

        StringContent content = new StringContent(jsonPayload, Encoding.UTF8, MEDIAJSON);
        using HttpRequestMessage request = new(HttpMethod.Patch, path);
        InjectToken(request);
        request.Content = content;
        HttpClient client = await GetClientAsync();
        using HttpResponseMessage response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            return await BuildResultObject<T>(response);
        }
        else
        {
            throw await BuildExcpetion("PATCH", path, response, jsonPayload);
        }

    }
    public async Task<bool> DeleteAsync(DynamicsQuery query)
    {
        return await DeleteAsync(query.GetPath());
    }
    public async Task<bool> DeleteAsync(string path)
    {
        HttpClient client = await GetClientAsync();
        using HttpRequestMessage request = new(HttpMethod.Delete, path);
        InjectToken(request);
        using HttpResponseMessage response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        return false;
    }

    private static async Task<T> BuildResultObject<T>(HttpResponseMessage response)
    {
        string result = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(result);
    }

    private static async Task<Exception> BuildExcpetion(string methode, string path, HttpResponseMessage response, string payload)
    {
        string errorContent = await response.Content.ReadAsStringAsync();
        throw new Exception($"Error during {methode} - Path: {path} stateCode: {response.StatusCode}  message: {response.ReasonPhrase} errorContent: {errorContent} |Data: {payload}");
    }
}
