using System;
using System.Collections.Generic;
using System.Text;

namespace Steiner_tree
{
    class Graph
    {
        public List<Vertex> vertices;
        public List<Edge> edges;

        public Graph(List<Vertex> vertexList, List<Edge> edgeList) {
            vertices = vertexList;
            edges = edgeList;
        }
    }
}
