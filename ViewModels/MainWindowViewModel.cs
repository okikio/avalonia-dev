using CommunityToolkit.Mvvm.ComponentModel;

namespace Jetlag.ViewModels;

public partial class MainWindowViewModel : ViewModelBase {
    [ObservableProperty] private string _greeting = "Welcome to Avalonia! It's running on native code right now!";
}