using System;

namespace FirstApp
{
    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        public override int Counter
        {
            get
            {
                return Counter;
            }
            set
            {
                if (value != 0) 
                {
                    Counter = value;
                }
                else
                {
                    Console.WriteLine("Число не может быть 0");
                }
            }
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }