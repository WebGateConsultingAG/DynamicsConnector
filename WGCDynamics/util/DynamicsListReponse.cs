using Newtonsoft.Json;
namespace WebGate.Dynamics.Util;
public class DynamicsListResponse<T>
    {
        public T value { get; set; }
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

    }