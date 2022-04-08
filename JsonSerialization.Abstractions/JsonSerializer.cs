namespace Staticsoft.JsonSerialization.Abstractions
{
    public interface JsonSerializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string json);
    }
}
