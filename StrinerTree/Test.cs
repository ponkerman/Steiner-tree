using System;
using System.Collections.Generic;
using System.Text;

namespace SteinerTree
{
    public class Test
    {
        public static bool EqTest(Graph G1, Graph G2)
        {
            
            if (new HashSet<Vertex>(G1.VerticesList).SetEquals(G2.VerticesList))
                if (new HashSet<Edge>(G1.EdgeList).SetEquals(G2.EdgeList))
                    return true;
            return false;
        }
    }
}
