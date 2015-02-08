using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            //axiom 1
            var axiom1 = new UndGraph<string>().allVertices.Count;

            //axiom2
            var axiom2 = new UndGraph<string>().allEdges.Count;

            //axiom3
            var axiom3 = new UndGraph<string>().countAllVertices();

            //axiom4
            var axiom4 = new UndGraph<string>().countAllEdges();

            //axiom5                 
                        
        }
    }
}
