using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DeepFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }


        public List<string> DepthFirstSearch(List<string> array)
        {
            // Write your code here.
            List<string> output = new List<string>();

            for (int i = 0; i < array.Count; i++)
            {
                //output.Add(array[i]);
                //recursive pattern
            }
            return output;
        }
    }


    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }


        public Node AddChild(string name)
        {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }
    }
}