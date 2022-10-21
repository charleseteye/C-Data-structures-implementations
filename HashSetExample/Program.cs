﻿using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {

            /* This example produces output similar to the following:
            * evenNumbers contains 5 elements: { 0 2 4 6 8 }
            * oddNumbers contains 5 elements: { 1 3 5 7 9 }
            * numbers UnionWith oddNumbers...
            * numbers contains 10 elements: { 0 2 4 6 8 1 3 5 7 9 }
            */


        static void Main(string[] args)
        {

           HashSet<int> evenNumbers = new HashSet<int>();
           HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0 ; i < 5; i++)
            {
                //populate numbers with just even numbers
                evenNumbers.Add(i * 2);
                //populate numbers with just odd numbers
                oddNumbers.Add((i * 2) +1);

            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);


            // Create a new HashSet populated with even numbers.
            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            // numbers.UnionWith(oddNumbers);
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);




            void DisplaySet(HashSet<int> collection)
            {
                Console.Write("{");
                foreach (int i in collection)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine(" }");
            }

        }

        //HashSet represent a set of values;

        


    }
}
