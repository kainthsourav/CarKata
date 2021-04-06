using System;
using System.Collections.Generic;
using System.Text;
using CarKataAssignment.Interface;
namespace CarKataAssignment
{
   public class CarOperations
    {
        private ICar _car;
        public CarOperations(ICar car)
        {
            _car = car;
        }
        public bool StartCar()
        {
            Console.WriteLine("-------- Welcome to Car Kata your journey begins --------");
            return _car.Start();
        }
        public bool StopCar()
        {
           return _car.Stop();
        }

        public bool AccelerateCar(int speed)
        {
            return _car.Accelerate(speed);
        }
        public bool ApplyBrake(int speed)
        {
            return _car.ApplyBrake(speed);
        }
    }
}
