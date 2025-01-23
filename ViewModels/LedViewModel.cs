using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RpiLedController.Models;

namespace RpiLedController.ViewModels;

internal partial class LedViewModel : ObservableObject
{
    private readonly Led _led;

    [ObservableProperty]
    private Color _color = Colors.DarkSlateGray;

    [RelayCommand]
    private void Toggle()
    {
        _led.IsOn = !_led.IsOn;
        Color = _led.IsOn ? Colors.Yellow : Colors.DarkSlateGray;
    }

    public LedViewModel()
    {
        _led = new Led
        {
            Name = "My LED",
            GpioPin = 18,
            IsOn = false
        };
    }
}