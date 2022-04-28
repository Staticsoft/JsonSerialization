namespace Staticsoft.Serialization.Abstractions
{
    public interface Serializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string json);
    }
}
