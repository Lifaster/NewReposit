using System;

namespace FirstApp
{
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }

    class Car
    {
        private double Fuel;

        private int Mileage;

        private string color;

        private TurnDirection turn;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            color = "White";
        }

        private void Move()
        {
            // Move a kilometer
            Mileage++;
            Fuel -= 0.5;
        }

        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }

        public string GetColor()
        {
            return color;
        }

        public void ChangeColor(string newColor)
        {
            if (color != newColor)
                color = newColor;
        }

        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }

        public bool IsTurningRight()
        {
            return turn == TurnDirection.Right;
        }
    }

    class TrafficLight
    {
        private void ChangeColor(string color)
        {

        }
        public string GetColor()
        { 
        }
    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }

    class User
    {
        private int age;
        private string login;
        private string email;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3) 
                {
                    Console.WriteLine("Логин должен быть не менее 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@") == true)
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Неверный email.");
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        {
            Department department = new Department();
            string name;
            if (department?.City?.Name == "Санкт-Петербург" && department?.Company?.Type == "Банк")
            {
                name = department?.Company?.Name ?? "Неизвестная компания";
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", name);
            }
        }
    }
}