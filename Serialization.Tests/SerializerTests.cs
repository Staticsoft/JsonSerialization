using Staticsoft.Serialization.Abstractions;
using Staticsoft.Testing;
using System;
using Xunit;

namespace Staticsoft.Serialization.Tests;

public abstract class SerializerTests : TestBase<Serializer>
{
    [Fact]
    public void CanSerializeAndDeserializeObject()
    {
        var obj = new
        {
            IntField = 42,
            StringField = "Hello, World",
            BoolField = true,
            FloatField = 13.37f,
            ObjectField = new
            {
                DateTimeField = DateTime.Today
            }
        };
        var deserialized = SerializeAndDeserialize(obj);
        Assert.Equal(obj, deserialized);
    }

    [Fact]
    public void CanSerializeAndDeserializeCaseInsensitive()
    {
        var serialized = SUT.Serialize(new LowercaseProperty { text = "Test" });
        var deserialized = SUT.Deserialize<UppercaseProperty>(serialized);
        Assert.Equal("Test", deserialized.Text);
    }

    T SerializeAndDeserialize<T>(T obj)
        => SUT.Deserialize<T>(SUT.Serialize(obj));
}

public class UppercaseProperty
{
    public string Text { get; init; }
}

public class LowercaseProperty
{
    public string text { get; init; }
}
