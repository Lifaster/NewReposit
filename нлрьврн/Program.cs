using System;

namespace FirstApp
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    class D : B
    {
        public new void Display()
        {
        }
    }
    class E : C
    {
        public new void Display()
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