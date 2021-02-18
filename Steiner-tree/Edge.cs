using System;
using System.Collections.Generic;
using System.Text;

namespace Steiner_tree
{
    class Edge
    {
        public Vertex vertex1, vertex2;

        public Edge(Vertex fst_vertex, Vertex sec_vertex) {
            vertex1 = fst_vertex;
            vertex2 = sec_vertex;
        }
    }
}
