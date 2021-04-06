using System;
using System.Collections.Generic;
using System.Text;
using CarKataAssignment.Interface;

namespace CarKataAssignment
{
   public class FuelTankOperations
    {
        private IFuelTank _fueltank;
        public FuelTankOperations(IFuelTank fuelTank)
        {
            _fueltank = fuelTank;
        }
        public void getdisplayDashboard()
        {
            _fueltank.displayDashboard();
        }
        public void getfuelconsumption()
        {
            _fueltank.fuelconsumption();
        }
        public bool getRefueled(int fuel)
        {
           return _fueltank.Refueled(fuel);
        }
    }
}
