using System;

namespace FirstApp
{
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager: Employee
    { 
        public string ProjectName;
    }

    class Developer : Employee
    { 
        public string ProgrammingLanguage; 
    }

    class Food
    {
    }
    class Fruit: Food
    {
    }
    class Vegetable: Food
    {
    }
    class Apple: Fruit
    {
    }
    class Banana : Fruit
    {
    }
    class Pear : Fruit
    {
    }
    class Potato: Vegetable
    {
    }
    class Carrot: Vegetable
    {
    }
    class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }