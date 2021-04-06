using CarKataAssignment.Constant;
using CarKataAssignment.Interface;
using CarKataAssignment.Implementation;
using System;

namespace CarKataAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar _car = new Car();
            IFuelTank _fuel = new FuelTank();

            CarOperations _carOperations = new CarOperations(_car);
            FuelTankOperations _tankOperations = new FuelTankOperations(_fuel);
            _tankOperations.getdisplayDashboard();

            while (true)
            {
                Console.WriteLine("1.Start Car");
                Console.WriteLine("2.Stop Car");
                Console.WriteLine("3.Brake Car");
                Console.WriteLine("4.Accelerate Car");
                Console.WriteLine("5.Refuel");

                int choice = Convert.ToInt16(Console.ReadLine());

                while (choice.ToString() == null)
                {
                    Console.WriteLine("Please Select a option");
                    choice = Convert.ToInt16(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                        _carOperations.StartCar();
                        _tankOperations.getdisplayDashboard();
                        break;
                    case 2:
                        _carOperations.StopCar();
                        _tankOperations.getdisplayDashboard();
                        break;
                    case 3:
                        Console.WriteLine("Enter Speed to reduce Speed Speed ");
                        int reduceSpeed = Convert.ToInt16(Console.ReadLine());
                        _carOperations.ApplyBrake(reduceSpeed);
                        _tankOperations.getfuelconsumption();
                        _tankOperations.getdisplayDashboard();
                        break;
                    case 4:
                        Console.WriteLine("Enter Speed to Increase Speed ");
                        int IncreaseSpeed = Convert.ToInt16(Console.ReadLine());
                        _carOperations.AccelerateCar(IncreaseSpeed);
                        _tankOperations.getdisplayDashboard();
                        break;
                    case 5:
                        Console.WriteLine("Enter Speed to Increase Speed ");
                        int fuel = Convert.ToInt16(Console.ReadLine());
                        _tankOperations.getRefueled(fuel);
                        _tankOperations.getdisplayDashboard();
                        break;
                    default:
                        Console.WriteLine("Please Select Valid option");
                        break;
                }
            }

           
            }
        }
}

