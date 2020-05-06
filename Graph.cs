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
        //get node by id , return null if the node doesnt exits
        public Node<T> getElement(int id)
        {
            Node<T> value;
            graph.TryGetValue(id, out value);
            return value;
        }
        // add Graph edge between two nodes , if the Nodes doesnt exits,
        // the function will do nothing
        public void addEdge(int source, int destination)
        {
            Node<T> s = getElement(source);
            Node<T> d = getElement(destination);
            if (s == null || d == null) return;
            s.adjecent.Add(d);
            d.adjecent.Add(s);
        }
        // find if there a path with BFS algorithm
        public bool hasPathBFS(int source, int destination)
        {
            Node<T> s = getElement(source);
            Node<T> d = getElement(destination);
            if (s == null || d == null) return false;
            return hasPathBFS(getElement(source), getElement(destination));
        }
        private bool hasPathBFS(Node<T> source, Node<T> destination)
        {
            Queue<Node<T>> nextToVisit = new Queue<Node<T>>();
            HashSet<int> visited = new HashSet<int>();
            nextToVisit.Enqueue(source);
            source.level = 0;
            while (nextToVisit.Count != 0)
            {
                Node<T> node = nextToVisit.Dequeue();
                updateChildLevel(node);
                if (node.Equals(destination)) return true;
                if (visited.Contains(node.id)) continue;
                visited.Add(node.id);
                foreach (Node<T> child in node.adjecent)
                    nextToVisit.Enqueue(child);
            }
            return false;
        }
        // return BFS path as Node<T> List.
        public List<Node<T>> PathBFS(int source, int destination)
        {
            Node<T> s = getElement(source);
            Node<T> d = getElement(destination);
            if (s == null || d == null) return new List<Node<T>>();
            return PathBFS(getElement(source), getElement(destination));
        }
        private List<Node<T>> PathBFS(Node<T> source, Node<T> destination)
        {
            bool hasPath = hasPathBFS(source, destination);
            List<Node<T>> result = new List<Node<T>>();
            if (!hasPath) return result; // there isnt path.

            uint level = destination.level;
            Node<T> temp = destination;

            while (level != 0)
            {
                result.Add(temp);
                foreach (Node<T> node in temp.adjecent)
                {
                    if (temp.level - 1 == node.level)
                    {
                        temp = node;
                        break;
                    }
                }
                level = temp.level; // set the child level
            }
            result.Add(source); // add the source node
            result.Reverse(); // reverse the result
            return result;
        }
        
        // update child nodes level
        private void updateChildLevel(Node<T> node)
        {
            foreach (Node<T> child in node.adjecent)
                child.level = (node.level + 1 < child.level) ? node.level + 1 : child.level;// 1 0
        }
    }
}
