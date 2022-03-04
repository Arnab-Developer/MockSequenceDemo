using Microsoft.Extensions.DependencyInjection;

namespace MockSequenceDemo.ConsoleApp;

internal static class StartUp
{
    public static IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddTransient<IDependency1, Dependency1>();
        services.AddTransient<IDependency2, Dependency2>();
        services.AddTransient<IWorker, Worker>();

        IServiceProvider serviceProvider = services.BuildServiceProvider();

        return serviceProvider;
    }
}