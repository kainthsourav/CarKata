using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataAssignment.Interface
{
   public interface ICar
    {
        bool Start();
        bool Stop();
        bool Accelerate(int speed);
        bool ApplyBrake(int speed);
    }
}
