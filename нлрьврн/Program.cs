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