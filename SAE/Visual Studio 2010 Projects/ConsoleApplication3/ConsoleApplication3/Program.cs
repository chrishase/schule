﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array1 = new double[100];
            double[] array2 = new double[100];
            Random rnd1 = new Random();

            for (int x = 0; x < array1.Length; x++)
            {
                array1[x] = rnd1.Next(1000);
            }

            for (int x = 0; x < array2.Length; x++)
            {
                array2[x] = rnd1.Next(1000);
            }


            Console.Write("\n Array 1 : \n");
            foreach (double x in array1)
            {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.Write("\n Array 2 : \n");
            foreach (double x in array2)
            {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.Write("\n Gemeinsame Zahlen: \n");
            foreach (double x in array1)
            {
                foreach (double y in array2)
                {  
                    if (x == y)
                    {
                        Console.Write(x);
                        Console.Write(" ");
                    }
                }
            }
            Console.Write("\n Zahlen im Array1 doppelt: \n");
            for(int i=0;i < array1.Length; i++)
            {
                double x = array1[i];
                for (int j = i + 1; j < array2.Length;j++ )
                {
                    double y = array1[j];
                    if (x == y)
                    {
                        Console.Write(x);
                        Console.Write(" ");
                    }
                }
            }
            Console.Write("\n Zahlen im Array2 gerade: \n");
            int iAnzahl = 0;
            foreach (double x in array2)
            {
                if (x % 2 == 0)
                {
                    iAnzahl++;
                }
            }
            Console.Write(iAnzahl);
            Console.Write(" nummern sind gerade! \n");

            iAnzahl = 0;
            foreach (double x in array1)
            {
                if ((x < 399) && (x > 300))
                {
                    iAnzahl++;
                }

            }
            foreach (double x in array1)
            {
                if ((x < 399) && (x > 300))
                {
                    iAnzahl++;
                }

            }
            Console.Write(iAnzahl);
            Console.Write(" nummern sind zwischen 300 und 399 \n");


            Console.ReadLine();
        }
    }
}
