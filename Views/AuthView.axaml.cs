using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReSafeStorage.ViewModels;

namespace ReSafeStorage;

public partial class ControlView : ReactiveUserControl<AuthViewModel>
{
    public ControlView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}