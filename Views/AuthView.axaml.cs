using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReSafeStorage.ViewModels;

namespace ReSafeStorage.Views;

public partial class AuthView : ReactiveUserControl<AuthViewModel>
{
    public AuthView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}