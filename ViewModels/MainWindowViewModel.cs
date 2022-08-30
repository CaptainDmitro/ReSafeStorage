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
    public class MainWindowViewModel : ViewModelBase, IScreen
    {
        public MainWindowViewModel(IAuthService authService)
        {
            Router.Navigate.Execute(new AuthViewModel(this, Router));
            GoNext = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new AuthViewModel(this, Router)));
        }
        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }
        public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

        public RoutingState Router { get; } = new RoutingState();


    }
}