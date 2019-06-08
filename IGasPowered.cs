namespace GarysGarage
{
    public interface IGasPowered
    {
        void RefuelTank();
        double FuelCapacity { get; set; }
    }
}