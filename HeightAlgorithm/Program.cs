using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HeightAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // i popullojme vlerat e tree-s
            Tree tree = new Tree();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Lartesia (height) e pemes eshte : " + tree.maxDepth(tree.root));
            Console.ReadLine();

        }
    }


}
