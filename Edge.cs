using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class Edge<T>
    {
        public Vertex Vertex1 { get; set; }

        public Vertex Vertex2 { get; set; }

        public T Element { get; set; }

        // you can have an edge without putting an element 
        public Edge(Vertex v1, Vertex v2)
        {
            this.Vertex1 = v1;
            this.Vertex2 = v2;
        }
               
        public Edge(Vertex v1, Vertex v2, T ele)
        {
            this.Vertex1 = v1;
            this.Vertex2 = v2;
            this.Element = ele;
        }


        



    }
}
