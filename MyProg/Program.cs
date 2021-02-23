using System;
using System.IO;
using System.Collections.Generic;
using SteinerTree;

namespace MyProg
{

    class Program 
    {
        
        const string path = @"../../../SteinerTree.txt";

        static void Main(string[] args)
        {
            
            List<Vertex> testV = new List<Vertex>();
            Graph referenceGraph = new Graph(); // primer
            Graph resultGraph = new Graph(); // resultat

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        testV.Add(new Vertex(Convert.ToDouble(line.Split(' ').GetValue(0)), Convert.ToDouble(line.Split(' ').GetValue(1))));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            referenceGraph = new Graph(new List<Vertex>(), new List<Edge>()); // stroim primer

            resultGraph.SteinerTreeBuilder(); // stroim derevo po alg


            Console.WriteLine("Equality to reference test: ");
            Console.WriteLine(Test.EqTest(referenceGraph, resultGraph));

        }
    }
}
