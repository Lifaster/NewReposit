﻿using System;
using System.Net.NetworkInformation;

namespace FirstApp
{
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}