using System.Collections.Generic;

namespace Graph
{

    class Node<T>
    {
        public Node(int id, T data)
        {
            this.data = data;
            this.id = id;
            adjecent = new List<Node<T>>();
        }
        public List<Node<T>> adjecent { get; set; }
        public T data { get; set; } // Generic Node Data.
        public int id { get; set; } 

    }
}