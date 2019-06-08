namespace GarysGarage
{
    public interface IElectricPowered
    {

        void ChargeBattery();
        double BatteryKWh { get; set; }
    }
}