namespace Staticsoft.JsonSerialization.Abstractions
{
    public interface Serializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string json);
    }
}
