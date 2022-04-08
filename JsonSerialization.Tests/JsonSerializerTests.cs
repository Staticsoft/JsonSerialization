using Staticsoft.JsonSerialization.Abstractions;
using Staticsoft.Testing;
using System;
using Xunit;

namespace Staticsoft.JsonSerialization.Tests
{
    public abstract class JsonSerializerTests<TSPF> : TestBase<JsonSerializer, TSPF>
        where TSPF : ServiceProviderFactory, new()
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

        T SerializeAndDeserialize<T>(T obj)
            => SUT.Deserialize<T>(SUT.Serialize(obj));
    }
}
