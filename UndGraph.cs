using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class UndGraph<T>
    {
        public HashSet<Edge<T>> allEdges;
        public HashSet<Vertex> allVertices;

        //newgraph
        public UndGraph()
        {
            allEdges = new HashSet<Edge<T>>();
            allVertices = new HashSet<Vertex>();
        }

        //temporary
        public void addEdge(Edge<T> edge)
        {
            allEdges.Add(edge);
        }

        //vertices
        public HashSet<Vertex> vertices() 
        {
            HashSet<Vertex> tempVertices = new HashSet<Vertex>();
            foreach (Edge<T> e in allEdges) 
            {
                if (!tempVertices.Contains(e.Vertex1))
                    tempVertices.Add(e.Vertex1);

                if (!tempVertices.Contains(e.Vertex2))
                    tempVertices.Add(e.Vertex2);
            };

            return tempVertices;
        }

        //edges
        public HashSet<Edge<T>> edges()
        {
            return allEdges;
        }

        //countAllVertices
        public int countAllVertices()
        {
            return allVertices.Count;
        }

        //countAllEdges
        public int countAllEdges()
        {
            return edges().Count();
        }

        //getEdge(v, w)
        public Edge<T> getEdge(Vertex v1, Vertex v2)
        {
            
            foreach (Edge<T> e in allEdges)
            {
                if ((e.Vertex1 == v1 || e.Vertex2 == v1) && (e.Vertex1 == v2 || e.Vertex2 == v2))
                    return e;
            }
            return null; //change this to return error
        }

        //incidentEdges(v)
        public HashSet<Edge<T>> incidentEdges(Vertex v)
        {
            HashSet<Edge<T>> edges = new HashSet<Edge<T>>();
            foreach (Edge<T> e in allEdges)
            {
                if (e.Vertex1 == v || e.Vertex2 == v)
                    edges.Add(e);
            }
            return edges;
        }

        //opposite(v, e)
        public Vertex opposite(Vertex v, Edge<T> e)
        {
            if (e.Vertex1 == v)
                return e.Vertex2;
            else return e.Vertex1;
        }

        //endVertices(e)
        public HashSet<Vertex> endVertices(Edge<T> e)
        {
            HashSet<Vertex> tempVertices = new HashSet<Vertex>();
            tempVertices.Add(e.Vertex1);
            tempVertices.Add(e.Vertex2);
            return tempVertices;
        }

        //areAdjacent(v, w):
        public bool areAdjacent(Vertex v1, Vertex v2)
        {
            return allEdges.Any(e => ((e.Vertex1 == v1 && e.Vertex2 == v2) || (e.Vertex1 == v2 && e.Vertex2 == v1)));
        }

        //insertVertex(v)
        public UndGraph<T> insertVertex(Vertex v)
        {
            if (allVertices.Contains(v))
                return this;
            allVertices.Add(v);
            return this;
        }

        //removeVertex(v)
        public UndGraph<T> removeVertex(Vertex v)
        {
            foreach (Edge<T> e in allEdges)
            {
                if (e.Vertex1 == v || e.Vertex2 == v)
                    allEdges.Remove(e);
            }
            allVertices.Remove(v);
            return this;
        }

        //insertEdge(v, w, x)
        public UndGraph<T> insertEdge(Vertex v1, Vertex v2, T element)
        {
            if (allEdges.Any(e => (e.Vertex1 == v1 && e.Vertex2 == v2) || (e.Vertex1 == v2 && e.Vertex2 == v1)))
                return this;

            Edge<T> newEdge = new Edge<T>(v1, v2, element);
            allEdges.Add(newEdge);
            return this;
        }

        //removeEdge(v, w)
        public UndGraph<T> removeEdge(Vertex v1, Vertex v2)
        {
            var edgeToRemove = allEdges.FirstOrDefault(e => (e.Vertex1 == v1 && e.Vertex2 == v2) || (e.Vertex1 == v2 && e.Vertex2 == v1));
            if (edgeToRemove != null) 
                allEdges.Remove(edgeToRemove);
            return this;
        }

        //getEdgeElem(e)
        public T getEdgeElem(Edge<T> e)
        {
            return e.Element;
        }

        //replaceEdgeElem(e, x)
        public UndGraph<T> replaceEdgeElem(Edge<T> e, T x)
        {
            e.Element = x;
            return this;
        }
	

    }
}
