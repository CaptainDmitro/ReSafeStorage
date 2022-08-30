using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReSafeStorage.ViewModels;

namespace ReSafeStorage.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            this.WhenActivated(disposables => { });
            InitializeComponent();
        }
    }
}