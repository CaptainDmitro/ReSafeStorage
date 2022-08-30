using ReSafeStorage.Service;
using Splat;

namespace ReSafeStorage;

public static class ServicesBootstraper
{
    public static void RegisterServices(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.Register<IAuthService>(() => new AuthService());
    }
}