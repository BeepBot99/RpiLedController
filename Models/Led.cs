namespace RpiLedController.Models;

internal class Led
{
    public int GpioPin { get; set; }
    public string Name { get; set; }
    public bool IsOn { get; set; }
}
