using System;
using System.Collections.Generic;
using System.Text;


namespace SteinerTree
{
    public class Edge
    {
        private Vertex vertex1, vertex2;
        public Vertex Vertex1 { get { return vertex1; } }
        public Vertex Vertex2 { get { return vertex2; } }

        public Edge(Vertex fst_vertex, Vertex sec_vertex)
        {
            vertex1 = fst_vertex;
            vertex2 = sec_vertex;
        }

    }


}
