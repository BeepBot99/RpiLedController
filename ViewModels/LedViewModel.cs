using CommunityToolkit.Mvvm.ComponentModel;

namespace RpiLedController.ViewModels;

internal partial class LedViewModel : ObservableObject
{
    [ObservableProperty]
    private string color = "Red";
}