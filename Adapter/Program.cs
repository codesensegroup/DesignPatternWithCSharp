using Adapter.Example;
using Adapter.Sample;
using Adapter.SimpleSample;
using MoreLinq;
using System;
using System.Collections.Generic;


namespace Adapter
{

    class Program
    {
      
        static void Main(string[] args)
        {
            // Example
            var vectorObjects = new List<VectorObject>{
                 new VectorRectangle(1, 1, 2, 2),
                 new VectorRectangle(3, 3, 6, 6)
            };
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(Draw.Point);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            // SimpleSample
            var classManager = new ClassManager();
            IClassManager IClassManager = new ClassAdapter(classManager);
            Console.WriteLine("Original Xml Output\n"+ classManager.GetAllStudents());
            Console.WriteLine("Adapter Json Output\n"+IClassManager.GetAllStudents());


        }

    }
}
