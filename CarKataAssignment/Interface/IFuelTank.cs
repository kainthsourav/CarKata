using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataAssignment.Interface
{
  public interface IFuelTank
    {
        bool Refueled(int fuel);
        void displayDashboard();
        void fuelconsumption();
    }
}
