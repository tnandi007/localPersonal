using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Program2
    {

        class Program
        {

        }

        public static void CreateGraph(List<IEnumerable<Edge>> graph)
        {
            graph.Add(new List<Edge> { new Edge(1, 2) });
            foreach(List<Edge> list in graph)
            {
                list.Add(new Edge(4, 5));
            }
        }
    }

    public class Edge
    {
        public int source { get; set; }
        public int dest { get; set; }

        public Edge(int s, int d)
        {
            source = s; 
            dest = d;   
        }
    }
}
