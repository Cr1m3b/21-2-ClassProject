﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Print();
            Console.Write("Give your Name: ");
            var s1 = Console.ReadLine();
            Console.WriteLine("Hello "+s1);
        }
        public static void Print()
        {
            Console.WriteLine("I am the print");
        }
    }
}
