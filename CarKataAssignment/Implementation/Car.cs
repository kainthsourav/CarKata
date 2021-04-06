using CarKataAssignment.Constant;
using CarKataAssignment.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataAssignment.Implementation
{
    public class Car : ICar
    {
        private bool isCarStart=false;
        private bool isApplyBrake = false;
        private bool isAccelerated = false;

        public bool Start()
        {
            if(!isCarStart)
            {
                Console.WriteLine("Car started");
            /*    CarConstant.currentSpeed += 10;*/
                isCarStart = true;
              
            }
            else
            {
                Console.WriteLine("Car is already started");
            }
            return isCarStart;
        }
        public bool Stop()
        {
            Console.WriteLine("Car Stopped");
            CarConstant.currentSpeed =0;
            return isCarStart = false;
          
        }
        public bool Accelerate(int speed)
        {
          
            if (isCarStart)
            {
                while (speed.ToString() == null)
                {
                    Console.WriteLine("Enter Speed to Increase Speed ");
                    speed = Convert.ToInt16(Console.ReadLine());
                }
                if (CarConstant.currentSpeed + speed > 250)
                {
                    Console.WriteLine("Car Speed cannot go beyond max speed :" + CarConstant.maxSpeed);
                    isAccelerated = false;
                }
                else if(speed<=5 && speed<=20)
                {
                    Console.WriteLine("Accelerate value can only be 5 to 20");
                    isAccelerated = false;
                }
                else
                {
                    CarConstant.currentSpeed += speed;
                    Console.WriteLine("Car Speed Changed");
                    isAccelerated = true;
                }  
            }
            else
            {
                Console.WriteLine("Please start the car first");
                isAccelerated = false;
            }
            return isAccelerated;
        }
        public bool ApplyBrake(int speed)
        {
          
            if(isCarStart)
            {
                CarConstant.currentSpeed -= speed;
                if(CarConstant.currentSpeed<0)
                {
                    CarConstant.currentSpeed=0;
                }
                Console.WriteLine("Brake Applied !!");
                isApplyBrake = true;
            }
            else
            {
                Console.WriteLine("Please start the car first");
                isApplyBrake = false;
            }
            return isApplyBrake;
        }
       
       
    }
}
