using AlgorithmPrograms.AnagramDetection;
using AlgorithmPrograms.BinarySearch;
using AlgorithmPrograms.BubbleSort;
using AlgorithmPrograms.CustomizeMessage;
using AlgorithmPrograms.DataStructureProblems;
using AlgorithmPrograms.DataStructureProblems.BalancedParentheses;
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
                Console.WriteLine("\nChoose Option to perform\n1.Binary Search for Word \n2.Insertion Sort \n3.Bubble sort " +
                   "\n4.Anagram \n5.Prime Range NUmber \n6.Customize Message \n7.UnOrder List(Data Structure Problems)" +
                   " \n8.Ordered List \n9.Balanced Parentheses \n10.Exit");
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
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case 5:
                       PrimeNumberRange primeNumberRange = new PrimeNumberRange();
                       primeNumberRange.PrimeRange();
                        break;
                    case 6:
                        CustomizeDetails customizeDetails = new CustomizeDetails();
                        customizeDetails.Customize();
                        break;
                    case 7:
                        UnOrderList unOrderList = new UnOrderList();
                        unOrderList.ReadFile(@"C:\Users\VISESH\Documents\bl excercise\AlgorithmProgram\AlgorithmPrograms\DataStructureProblems\UnOrderList.cs");
                        break;
                    case 8:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadFile(@"C:\Users\VISESH\Documents\bl excercise\AlgorithmProgram\AlgorithmPrograms\DataStructureProblems\OrderedList.cs");
                        break;
                    case 9:
                        BalancedOpeartion balanced = new BalancedOpeartion();
                        balanced.ReadFile(@"C:\Users\VISESH\Documents\bl excercise\AlgorithmProgram\AlgorithmPrograms\DataStructureProblems\BalancedParantheses\File.txt");
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }

        }
    }
}