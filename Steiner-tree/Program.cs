using System;
using System.IO;
using System.Collections.Generic;

namespace Steiner_tree
{
    struct coord {
        public double x, y;
        public coord(double x, double y) {
            this.x = x;
            this.y = y;
        }
    }

    class Program : ISteiner, ITest
    {
        const string path = @"../../../SteinerTree.txt";

        static void Main(string[] args)
        {
            List<Vertex> testV = new List<Vertex>();
            Graph testGraph;
            Graph referenceGraph;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        testV.Add(new Vertex(new coord(Convert.ToDouble(line.Split(' ').GetValue(0)), Convert.ToDouble(line.Split(' ').GetValue(1)))));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            testGraph = new Graph(testV, new List<Edge>());
            referenceGraph = new Graph(new List<Vertex>(), new List<Edge>());
            Console.WriteLine("Equality to reference test: ");
            Console.WriteLine(ITest.EqTest(referenceGraph, ISteiner.SteinerTree(testGraph.vertices)));

        }
    }
}
