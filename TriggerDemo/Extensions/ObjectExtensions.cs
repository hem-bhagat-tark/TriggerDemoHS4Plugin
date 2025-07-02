using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace HSPI_TriggerDemo.Extensions
{
    public static class ObjectExtensions
    {
        public static string Serialize(this object data)
        {
            return JsonConvert.SerializeObject(data, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        public static T Deserialize<T>(this string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
