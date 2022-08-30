using ReSafeStorage.Service;
using Splat;

namespace ReSafeStorage;

public static class Bottstraper
{
    public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        ServicesBootstraper.RegisterServices(services, resolver);
        ViewModelsBootstraper.RegisterViewModels(services, resolver);
    }
}