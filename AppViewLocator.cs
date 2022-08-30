using System;
using ReactiveUI;
using ReSafeStorage.ViewModels;
using ReSafeStorage.Views;

namespace ReSafeStorage;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
    {
        AuthViewModel context => new AuthView { DataContext = context },
        ControlViewModel context => new ControlView { DataContext = context},
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}