using QuickGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    public class Graphs
    {
        public void CreateGraph()
        {
            var edges = new SEdge<int>[] { new SEdge<int>(1, 2), new SEdge<int>(0, 1) };
            var graph = edges.ToAdjacencyGraph<int, SEdge<int>>();

            var markedAdjacencyGraph = new AdjacencyGraph<int, TaggedEdge<int, string>>();

            markedAdjacencyGraph.AddVertex(1);
            markedAdjacencyGraph.AddVertex(2);
            markedAdjacencyGraph.AddEdge(new TaggedEdge<int, string>(1, 2, "One to Two"));
            markedAdjacencyGraph.AddEdge(new TaggedEdge<int, string>(2, 1, "Two to One"));

            foreach (var v in markedAdjacencyGraph.Vertices)
            {
                Console.WriteLine(v);
            }
        }
    }
}
