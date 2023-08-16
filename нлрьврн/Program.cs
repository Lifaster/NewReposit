using System;
using System.Net.NetworkInformation;

namespace FirstApp
{
    class Car<T>
    {
        public T Engine;
        public virtual void ChangePart<T2>(T2 NewPart) { }
    }
    class GasEngine
    {
    }
    class ElectricEngine
    {
    }
    class Battery { }
    class Differential { }
    class Wheel { }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}