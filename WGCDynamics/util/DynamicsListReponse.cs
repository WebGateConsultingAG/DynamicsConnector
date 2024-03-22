using Newtonsoft.Json;

public class DynamicsListResponse<T>
    {
        public T value { get; set; }
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

    }