﻿using Microsoft.Extensions.DependencyInjection;
using Staticsoft.JsonSerialization.Net;
using Staticsoft.Testing;

namespace Staticsoft.JsonSerialization.Tests
{
    public class SystemJsonSerializerTests : JsonSerializerTests<SystemJsonSerializerDependencies> { }

    public class SystemJsonSerializerDependencies : UnitServicesBase
    {
        protected override IServiceCollection Services => base.Services
            .UseSystemJsonSerializer();
    }
}
