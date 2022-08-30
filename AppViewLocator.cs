using System;
using ReactiveUI;
using ReSafeStorage.ViewModels;

namespace ReSafeStorage;

public class AppViewLocator : ReactiveUI.IViewLocator
{
    public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
    {
        AuthViewModel context => new ControlView { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}