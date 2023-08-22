using System;
using System.Net.NetworkInformation;

namespace FirstApp
{
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TCarPart>(TCarPart newPart) where TCarPart : CarPart
        {
        }
    }
    class Engine { }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { }
    class CarPart { }
    class Battery : CarPart { }
    class Differential : CarPart { }
    class Wheel : CarPart { }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}