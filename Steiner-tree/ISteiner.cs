using System;
using System.Collections.Generic;
using System.Text;

namespace Steiner_tree
{
    interface ISteiner
    {
        static Graph SteinerTree(List<Vertex> V) { return new Graph(new List<Vertex>(), new List<Edge>()); }
    }
}
