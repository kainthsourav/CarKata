using System;
using System.Collections.Generic;
using System.Text;
using CarKataAssignment.Constant;
using CarKataAssignment.Interface;

namespace CarKataAssignment.Implementation
{
    public class FuelTank : IFuelTank
    {
        private bool isRefueled = false;
        public bool Refueled(int fuel)
        {
            Console.WriteLine("Enter Fuel Level : ");
            fuel = Convert.ToInt16(Console.ReadLine());
            while (fuel.ToString() == null)
            {
                Console.WriteLine("Enter Fuel Level : ");
                fuel = Convert.ToInt16(Console.ReadLine());
            }
            if (CarConstant.defaultFuel + fuel > 60)
            {
                Console.WriteLine("Fuel levels cannot exceeds max fuel level");
                isRefueled = false;
            }
            else
            {
                CarConstant.defaultFuel += fuel;
                isRefueled = true;
            }
            return isRefueled;

        }
        public void displayDashboard()
        {
            Random randomNumbers = new Random();
            int currentTemp = randomNumbers.Next(0, 50);
            Console.WriteLine("-------- Dashboard --------");
            Console.WriteLine("Current Fuel Level :" + CarConstant.defaultFuel);
            if (CarConstant.defaultFuel <= 5)
            {
                Console.WriteLine("fuel tank is on reserve");
            }
            Console.WriteLine("Current Speed : " + CarConstant.currentSpeed);
            Console.WriteLine("Current Temperature : " + currentTemp + " C\n");
        }

        public void fuelconsumption()
        {
            if (CarConstant.currentSpeed > 1 && CarConstant.currentSpeed <= 60)
            {
                CarConstant.defaultFuel -= 0.0020;
            }
            else if (CarConstant.currentSpeed >= 61 && CarConstant.currentSpeed <= 100)
            {
                CarConstant.defaultFuel -= 0.0014;
            }
            else if (CarConstant.currentSpeed >= 101 && CarConstant.currentSpeed <= 140)
            {
                CarConstant.defaultFuel -= 0.0020;
            }
            else if (CarConstant.currentSpeed >= 141 && CarConstant.currentSpeed <= 200)
            {
                CarConstant.defaultFuel -= 0.0025;
            }
            else if (CarConstant.currentSpeed >= 201 && CarConstant.currentSpeed <= 250)
            {
                CarConstant.defaultFuel -= 0.0030;
            }
            else
            {
                CarConstant.defaultFuel -= 0.0003;
            }
           
        }
    }
}
