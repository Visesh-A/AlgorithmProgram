﻿using AlgorithmPrograms.BinarySearch;
using AlgorithmPrograms.BubbleSort;
using AlgorithmPrograms.InsertionSort;
using System;
namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose Option to perform\n1.Binary Search for Word \n2.Insertion Sort \n3.Bubble sort \n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinaryWrodSearch search = new BinaryWrodSearch();
                        search.ReadFile(@"C:\Users\VISESH\Documents\bl excercise\AlgorithmProgram\AlgorithmPrograms\BinarySearch\File.txt");
                        break;
                    case 2:
                        InserationSorting sorting = new InserationSorting();
                        sorting.ReadFile(@"C:\Users\VISESH\Documents\bl excercise\AlgorithmProgram\AlgorithmPrograms\InsertionSort\InsertionSorting.cs");
                        break;
                    case 3:
                        Bubble bubble = new Bubble();
                        bubble.ReadFile(@"C:\Users\VISESH\Documents\bl excercise\AlgorithmProgram\AlgorithmPrograms\BubbleSort\File.txt");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }

        }
    }
}
