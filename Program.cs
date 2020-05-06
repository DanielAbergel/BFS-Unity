using System;
using System.Diagnostics;
namespace Graph
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();
            Console.WriteLine("Start");
            graph.addElement(new Node<string>(0, "0"));
            graph.addElement(new Node<string>(1, "1"));
            graph.addElement(new Node<string>(2, "2"));
            graph.addElement(new Node<string>(3, "3"));
            graph.addElement(new Node<string>(4, "4"));
            graph.addElement(new Node<string>(5, "5"));
            graph.addElement(new Node<string>(6, "6"));
            graph.addElement(new Node<string>(7, "7"));
            graph.addElement(new Node<string>(8, "8"));
            graph.addElement(new Node<string>(9, "9"));
            
            graph.addEdge(0,1);
            graph.addEdge(1,2);
            graph.addEdge(2,3);
            graph.addEdge(1,4);            
            graph.addEdge(1,5);
            graph.addEdge(1,6);
            graph.addEdge(1,9);
            graph.addEdge(9,8);
            graph.addEdge(8,7);
            
            // How to use BFS Algorithm
            Console.WriteLine(graph.hasPathBFS(1,7));
            Console.WriteLine(graph.hasPathBFS(1,8));
            Console.WriteLine(graph.hasPathBFS(1,9));
            // BFS Path .
            string reuslt  = "";
            var resultList = graph.PathBFS(1,7);
            foreach(Node<string> node in resultList)
                reuslt += node.id + " ";
            Console.WriteLine(reuslt);
            
            Console.WriteLine("End");
        }
    }
}
