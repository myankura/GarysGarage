using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();
            Tesla model3 = new Tesla();
            Tesla modelX = new Tesla();
            Tesla modelY = new Tesla();

            //Add electric vehicles to the list
            List<IElectricPowered> electricVehicles = new List<IElectricPowered>{
                fx,fxs,modelS,model3,modelX,modelY
            };

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            //Add gas vehicles to list
            List<IGasPowered> gasVehicles = new List<IGasPowered>{
                ram, cessna150
            };

            //Refuel gas vehicles
            gasVehicles.ForEach(gv => gv.RefuelTank());
        }
    }
}
