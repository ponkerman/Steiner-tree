using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace SteinerTree
{

    public class Graph : ITreeLength, IConnectivity, ISteiner
    {
        private List<Vertex> vertices;
        private List<Edge> edges;

        public List<Vertex> VerticesList { get { return vertices; } }
        public List<Edge> EdgeList { get { return edges; } }

        public Graph(List<Vertex> vertexList, List<Edge> edgeList)
        {
            vertices = vertexList;
            edges = edgeList;
        }
        public Graph()
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
        }

        private double TreeLength(Graph tree) {
            double length = 0;
            foreach (var i in tree.edges)
                length += Math.Abs(i.Vertex1.X - i.Vertex2.X) + Math.Abs(i.Vertex1.Y - i.Vertex2.Y);

            if (length != 0) return length;
            return null;
        }
        private bool? ConnectivityCheck(Graph tree) {
            List<Vertex> tempV = tree.vertices;
            foreach (var ed in tree.edges) 
                foreach (var ver in tempV) 
                    if (ed.Vertex1 == ver || ed.Vertex2 == ver)
                        tempV.Remove(ver);

            if (tempV.Count == 0) return true;
            return false;
        }

        public void addV(Vertex v) { }
        public void addE(Edge e) { }

        public void removeV(Vertex v) { }
        public void removeE(Edge e) { }

        public void SteinerTreeBuilder() {
            this.vertices = new List<Vertex>();
            this.edges = new List<Edge>(); 
        }

        

        private Graph STfragment(List<Vertex> verList) {
            List<Edge> edges = new List<Edge>();
            List<Vertex> vertices = new List<Vertex>();
            double bestLength = 0;
            List<Edge> bestEdges = edges;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    vertices.Add(new Vertex(verList[i].X, verList[j].Y));
                }
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    edges.Add(new Edge(vertices[i*3+j], vertices[i*3+j+3]));
                }
            }

            for (int i = 1; i < vertices.Count; i++) {
                if (i % 3 == 0)
                    edges.Add(new Edge(vertices[i], vertices[i - 1]));
            } 

            foreach (var subset in edges.PowerSets())
            {
                double length = TreeLength(new Graph(vertices, edges));
                if (length > bestLength) { 
                    bestLength = length;
                    bestEdges = edges;
                }
            }


            return new Graph(vertices, bestEdges);
        }



    }

}
