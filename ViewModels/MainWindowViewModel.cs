using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using System.Text.RegularExpressions;
using Avalonia.Logging;
using Microsoft.VisualBasic;
using ReactiveUI;
using Renci.SshNet;
using ReSafeStorage.Service;

namespace ReSafeStorage.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IAuthService _authService;
        private string _userName = "";
        private string _password = "";

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

        public MainWindowViewModel(IAuthService authService)
        {
            _authService = authService;
        }

        // TODO: Move signIn/signUp logic to repository
        private void SignIn() => _authService.SignIn(UserName, Password);
        private void SignUp() => _authService.SignUp(UserName, Password);
    }
}