
using _06.SmartDevicesSystem;

SmartDevice smartDevice = new SmartDevice()
{
    Name = "Умен климатик"
};

smartDevice.TurnOn();

smartDevice.Connect("Home_WiFi");

smartDevice.ShowStatus();

smartDevice.Disconnect();

smartDevice.TurnOff();
