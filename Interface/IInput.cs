public interface IInput
{
    void OnDeviceLost();
    void OnDeviceRegained();
    void OnControlsChanged();
}