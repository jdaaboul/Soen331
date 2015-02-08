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
            var v1 = new Vertex("v1");
            var v2 = new Vertex("v2");
            var v3 = new Vertex("v3");
            var v4 = new Vertex("v4");
            var v5 = new Vertex("v5");
            var v6 = new Vertex("v6");

            var edge1 = new Edge<string>(v1, v2);
            var edge2 = new Edge<string>(v1, v4);
            var edge3 = new Edge<string>(v5, v6);

            var test = new UndGraph<string>();
            var p = 11111;
            test.addEdge(edge1);
            test.addEdge(edge2);
            test.addEdge(edge3);

            var vertices = test.vertices();
            var edges = test.edges();
            var countVertices = test.countAllVertices();
            var countEdges = test.countAllEdges();
            var getEdge = test.getEdge(v2, v1);
            var incidentEdges = test.incidentEdges(v1);
            var opposite = test.opposite(v1, edge1);
            var areAdjacent = test.areAdjacent(v1, v2);


            
        }
    }
}
