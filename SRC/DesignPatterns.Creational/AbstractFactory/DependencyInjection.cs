using DesignPatterns.Creational.AbstractFactory.Dark;
using DesignPatterns.Creational.AbstractFactory.Light;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Creational.AbstractFactory;

public static class DependencyInjection
{
    public static IServiceCollection AddAbstractFactory(this IServiceCollection services)
    {
        services.AddTransient<LightUIFactory>();
        services.AddTransient<DarkUIFactory>();
        return services;
    }
}
