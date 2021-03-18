using System;
using System.Collections.Generic;
using System.Text;

namespace SteinerTree
{
    interface ISteiner
    {
        private void STBuilder() { }
        private Graph STfragment(List<Vertex> verList) { return new Graph(); }
    }
}
