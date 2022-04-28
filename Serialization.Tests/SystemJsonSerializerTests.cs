using Microsoft.Extensions.DependencyInjection;
using Staticsoft.Serialization.Net;
using Staticsoft.Testing;

namespace Staticsoft.Serialization.Tests
{
    public class SystemJsonSerializerTests : SerializerTests<SystemJsonSerializerDependencies> { }

    public class SystemJsonSerializerDependencies : UnitServicesBase
    {
        protected override IServiceCollection Services => base.Services
            .UseSystemJsonSerializer();
    }
}
