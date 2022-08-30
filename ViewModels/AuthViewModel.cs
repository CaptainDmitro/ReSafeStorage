using System;
using ReactiveUI;
using ReSafeStorage.Service;
using Splat;

namespace ReSafeStorage.ViewModels;

public class AuthViewModel : ViewModelBase, IRoutableViewModel
{
    private IAuthService _authService;
    public string? UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    public IScreen HostScreen { get; }
    private string _userName = "";
    private string _password = "";
    
    public RoutingState Router { get; }
    public string UserName
    {
        get => _userName;
        set => this.RaiseAndSetIfChanged(ref _userName, value);
    }
        
    public string Password
    {
        get => _password;
        set => this.RaiseAndSetIfChanged(ref _password, value);
    }

    public AuthViewModel(IScreen screen, RoutingState router)
    {
        HostScreen = screen;
        _authService = new AuthService();
        Router = router;
        var r = Locator.Current.GetService<RoutingState>();
        Console.WriteLine($"r = {r}");
        Console.WriteLine($"router = {Router}");
    }
    
    // private void SignIn() => _authService.SignIn(UserName, Password);
    private void SignIn() { Router.Navigate.Execute(new ControlViewModel(HostScreen, Router)); }
    private void SignUp() => _authService.SignUp(UserName, Password);
}