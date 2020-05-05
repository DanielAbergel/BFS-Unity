using System.Collections.Generic;

namespace Graph
{

    class Graph<T>
    {

        public Graph()
        {
            graph = new Dictionary<int, Node<T>>();
        }
        public Dictionary<int, Node<T>> graph { get; set; }
        public void addElement(Node<T> node)
        {
            if (node != null) graph.Add(node.id, node);
        }
        public Node<T> getElement(int id)
        {
            Node<T> value;
            graph.TryGetValue(id, out value);
            return value;
        }

        public void addEdge(int source, int destination)
        {
            Node<T> s = getElement(source);
            Node<T> d = getElement(destination);
            if(s == null || d == null) return;
            s.adjecent.Add(d);
        }

        public bool hasPathBFS(int source, int destination)
        {
            Node<T> s = getElement(source);
            Node<T> d = getElement(destination);
            if(s == null || d == null) return false;
            return hasPathBFS(getElement(source),getElement(destination));
        }
        private bool hasPathBFS(Node<T> source, Node<T> destination)
        {
            Queue<Node<T>> nextToVisit = new Queue<Node<T>>();
            HashSet<int> visited = new HashSet<int>();
            nextToVisit.Enqueue(source);
            while (nextToVisit.Count != 0)
            {
                Node<T> node = nextToVisit.Dequeue();
                if (node.Equals(destination)) return true;
                if (visited.Contains(node.id)) continue;
                visited.Add(node.id);
                foreach (Node<T> child in node.adjecent)
                    nextToVisit.Enqueue(child);
            }
            return false;
        }
    }
}