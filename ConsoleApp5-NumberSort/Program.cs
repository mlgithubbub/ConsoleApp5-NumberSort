using System;
using System.Collections.Generic;

namespace ConsoleApp5_NumberSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Function that allows user input of number strings, parsing to integers, and creation of a list of integers
            List<int> numList = numberInput();
            //Function that takes integer list in as paramater and outputs a sorted integer list
            List<int> sortedList = sortNumbers(numList);
            //Function to print the sorted integer list to the console
            outputSortedList(sortedList);
        }

        private static void outputSortedList(List<int> sortedList)
        {
            // List<int> numList = new List<int>();

            Console.WriteLine("Here is the sorted list:");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList[i]);
            }
        }

        private static List<int> sortNumbers(List<int> numList)
        {
            for (int i = 0; i < numList.Count; i++)
            {
                for (int j = i + 1; j < numList.Count; j++)
                {
                    if (numList[i] > numList[j])
                    {
                        numList.Insert(j + 1, numList[i]);
                        numList.Insert(i, numList[j]);
                        numList.RemoveAt(i + 1);
                        numList.RemoveAt(j);
                    }
                }
            }

            return numList;
        }

        private static List<int> numberInput()
        {
            Console.WriteLine("Enter random numbers, pressing enter after each number, and typing \"x\" to stop.");
            string numString = Console.ReadLine();

            List<int> numList = new List<int>();

            //So long as the number string is not equal to "x",...
            while (numString != "x")
            {
                //... parse the integer into a string, add it to the list of numbers, and read the next line of input
                int numInt = int.Parse(numString);
                numList.Add(numInt);
                numString = Console.ReadLine();
            }

            return numList;
        }
    }
}