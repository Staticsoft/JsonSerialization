using Microsoft.Extensions.DependencyInjection;
using Staticsoft.Serialization.Abstractions;

namespace Staticsoft.Serialization.Net
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection UseSystemJsonSerializer(this IServiceCollection services)
            => services
                .AddSingleton<SystemJsonSerializer>()
                .ReuseSingleton<Serializer, SystemJsonSerializer>()
                .ReuseSingleton<JsonSerializer, SystemJsonSerializer>();
    }
}
