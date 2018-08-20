﻿using System;

namespace methodsAndDebugging
{
    class MainClass
    {
		public static void Main(string[] args)
		{
            PrintHeader();
            PrintBody();
            PrintFooter();
		}


        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
