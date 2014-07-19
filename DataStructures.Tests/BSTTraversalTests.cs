using System;
using System.Linq;
using DataStructures.BinaryTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class BSTTraversalTests
    {
        [TestMethod]
        public void InOrderTraversalPositiveIntegers()
        {
            int[] unsortedArray = {3, 5, 4, 1, 2};

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            var orderedArray = unsortedArray.OrderBy(i => i).ToArray();

            var inorderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();
            
            Assert.AreEqual(orderedArray.Length, inorderTraversal.Length);

            for (int i = 0; i < orderedArray.Length; i++)
            {
                Assert.AreEqual(orderedArray[i], inorderTraversal[i]);
            }
        }

        [TestMethod]
        public void InOrderTraversalNegativeIntegers()
        {
            int[] unsortedArray = { -3, -5, -4, -1, -2 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            var orderedArray = unsortedArray.OrderBy(i => i).ToArray();

            var inorderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(orderedArray.Length, inorderTraversal.Length);

            for (int i = 0; i < orderedArray.Length; i++)
            {
                Assert.AreEqual(orderedArray[i], inorderTraversal[i]);
            }
        }

        [TestMethod]
        public void InOrderTraversalDoubles()
        {
            double[] unsortedArray = { -3.3, -5.1, -4.9, -1.0, -2.2, 2.1, 3.1 };

            BST<double> bst = new BST<double>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            var orderedArray = unsortedArray.OrderBy(i => i).ToArray();

            var inorderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(orderedArray.Length, inorderTraversal.Length);

            for (int i = 0; i < orderedArray.Length; i++)
            {
                Assert.AreEqual(orderedArray[i], inorderTraversal[i]);
            }
        }

    }
}
