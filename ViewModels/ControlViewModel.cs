using System;
using ReactiveUI;

namespace ReSafeStorage.ViewModels;

public class ControlViewModel : ViewModelBase, IRoutableViewModel
{
    public string? UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    public IScreen HostScreen { get; }
    public RoutingState Router { get; }

    public ControlViewModel(IScreen screen, RoutingState router)
    {
        HostScreen = screen;
        Router = router;
    }
}