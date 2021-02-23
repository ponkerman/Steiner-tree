using System;
using System.Collections.Generic;
using System.Text;

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

        public void addV(Vertex v) { }
        public void addE(Edge e) { }

        public void removeV(Vertex v) { }
        public void removeE(Edge e) { }

        public void SteinerTreeBuilder() {
            this.vertices = new List<Vertex>();
            this.edges = new List<Edge>(); 
        }

        
    }
}
