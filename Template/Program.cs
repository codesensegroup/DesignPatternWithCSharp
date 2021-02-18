using System;
using System.Collections.Generic;
using System.Linq;
using Template.Abstract;
using Template.Generic;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simple MergeSort not use pattern
            var seed = new Random(1024);
            var unsortSets = Enumerable.Range(0, 10).Select(r => seed.Next(100)).ToList();
           
            Console.WriteLine("Original Sets:");
            foreach (var item in unsortSets)
                Console.Write(item + " ");
            
            Console.WriteLine();

            var algorithm = new MergeSortAlgorithm();
            var sorted = algorithm.Sort(unsortSets);

            Console.WriteLine("Sorted: ");
            foreach (var item in sorted)
                Console.Write(item + " ");

            Console.WriteLine();

            // Use Pattern
            unsortSets = Enumerable.Range(0, 10).Select(r => seed.Next(100)).ToList();
            Console.WriteLine("Original Sets:");
            foreach (var item in unsortSets)
                Console.Write(item + " ");

            Console.WriteLine();

            var algorithmWithGeneric = new MergeSortWithGeneric<int>();
            sorted = algorithmWithGeneric.Sort(unsortSets);

            Console.WriteLine("Sorted : ");
            foreach (var item in sorted)
                Console.Write(item + " ");

            Console.WriteLine();

            // Sort Student
            var names = new List<string>()
            {
                "Spyua"       ,
                "Tom"     ,
                "Mary"             
            };
            var personSets = Enumerable.Range(0, 3).Select(r => new Student(names[r], seed.Next(100))).ToList();

            Console.WriteLine("Student Original Sets:");
            foreach (var item in personSets)
                Console.WriteLine(item + " ");

            Console.WriteLine();

            var mergeSort = new MergeSort<Student>(personSets);
            mergeSort.Run();

            Console.WriteLine();

            var quickSort = new QuickSort<Student>(personSets);
            quickSort.Run();


        }
    }
}
