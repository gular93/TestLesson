﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLesson
{
    class Car
    {
        //Access Modifier--public,private
        public static int Speed = 0;
        int a = 5;
        
        string Color;
        public string Name;
        public int Year;
        //int[] params
        //default constructor
        //signature

        //overload
        public Car(string name, string color)
        {
            Color = color + "1";
            Name = name;
            Year = 2001;
        }
        public Car()
        {
            Console.WriteLine("Helloo ");

        }
        public Car(int d,string soz)
        { 

        }
        static Car()
        {
            Console.WriteLine("Hi Static");
        }
        //accessmodifier returntype MethodName(input params)
       // {
       //body
       
       // }
        public void Start(params int[] numbers)
        {
            Console.WriteLine(numbers[0]);
            Console.WriteLine($"Created new car {Name}");
        }



    }
}
