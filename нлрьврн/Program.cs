using System;

namespace FirstApp
{
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor: ComputerPart
    {
        public override void Work()
        {
        
        }
    }
    class MotherBoard : ComputerPart
    {
        public override void Work()
        {

        }
    }


    class Program
        {
            static void Main(string[] args)
            {
            }
        }
}