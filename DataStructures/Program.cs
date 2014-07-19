using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.BinaryTrees;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {11, 6, 8, 19, 4, 10, 5, 17, 43, 49, 31};
            BST<int> bst = new BST<int>();

            foreach (var i in data)
            {
                bst.Insert(i);
            }

            var list = bst.Traverse(TreeTraversalType.InOrder);

            foreach (var i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(bst.Search(11));

            Console.WriteLine(bst.Search(12));

            Console.WriteLine(bst.Search(31));
        }
    }
}
