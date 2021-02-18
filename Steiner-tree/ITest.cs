using System;
using System.Collections.Generic;
using System.Text;

namespace Steiner_tree
{
    interface ITest
    {
        static bool EqTest(Graph G1, Graph G2)
        {
            if (G1 == G2)
                return true;
            return false;
        }
    }
}
