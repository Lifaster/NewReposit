using System;
using System.Net.NetworkInformation;

namespace FirstApp
{
    class Car<T1> where T1 : Engine
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
        {
        }
    }
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