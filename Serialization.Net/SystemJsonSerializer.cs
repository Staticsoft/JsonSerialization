using Staticsoft.JsonSerialization.Abstractions;
using Json = System.Text.Json;

namespace Staticsoft.JsonSerialization.Net
{
    public class SystemJsonSerializer : JsonSerializer
    {
        readonly Json.JsonSerializerOptions Options = new() { PropertyNameCaseInsensitive = true };

        public string Serialize<T>(T obj)
            => Json.JsonSerializer.Serialize(obj);

        public T Deserialize<T>(string json)
            => Json.JsonSerializer.Deserialize<T>(json, Options);
    }
}
