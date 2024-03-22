
using Newtonsoft.Json.Linq;

namespace WebGate.Dynamics.Util.Extensions;
public static class DynamicsEntityUtils
    {
        public static void AddSingleReference(this JObject json, string field, string table, string id)
        {
            json[field + "@odata.bind"] = string.IsNullOrEmpty(id) ? null : "/" + table + "(" + id + ")";
        }

        public static JObject RemoveDirectReference(this JObject json)
        {
            JObject result = new JObject();
            foreach( var property in json.Properties())
            {
                
                if (!(property.Name.StartsWith("_") && property.Name.EndsWith("_value")))
                {
                    result.Add(property);
                }
            }
            return result;
        }
    }