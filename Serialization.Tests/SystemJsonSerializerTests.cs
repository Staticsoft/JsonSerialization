using Microsoft.Extensions.DependencyInjection;
using Staticsoft.Serialization.Net;

namespace Staticsoft.Serialization.Tests;

public class SystemJsonSerializerTests : SerializerTests
{
    protected override IServiceCollection Services => base.Services
        .UseSystemJsonSerializer();
}
