using ReSafeStorage.Service;
using ReSafeStorage.ViewModels;
using Splat;

namespace ReSafeStorage;

public static class ViewModelsBootstraper
{
    public static void RegisterViewModels(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.Register(() => new MainWindowViewModel(
            resolver.GetService<IAuthService>()
        ));
    }
}