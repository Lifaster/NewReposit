using System;

namespace FirstApp
{
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public TowClass(string name, string description): base(name)
        {
            Description = description;
        }

        public KloClass(string name, string description, int counter): base(name)
        {
            Description = description;
            Counter = counter;
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }