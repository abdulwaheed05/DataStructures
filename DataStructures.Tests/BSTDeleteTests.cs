using System;
using DataStructures.BinaryTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class BSTDeleteTests
    {
        [TestMethod]
        public void DeleteLeafNode()
        {
            int[] unsortedArray = { 3, 5, 4, 1, 2 };
            int[] sortedArray = { 1, 3, 4, 5 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            bst.DeleteNode(2);
            Assert.IsFalse(bst.Search(2));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);
            
            for(int i=0; i<sortedArray.Length;i++)
            {
               Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteNodeWithRightChild()
        {
            int[] unsortedArray = { 3, 5, 4, 1, 2 };
            int[] sortedArray = { 2, 3, 4, 5 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(1));
            Assert.IsFalse(bst.Search(1));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteNodeWithLeftChild()
        {
            int[] unsortedArray = { 3, 5, 4, 1, 2 };
            int[] sortedArray = { 1, 2, 3, 4 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(5));
            Assert.IsFalse(bst.Search(5));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteNodeWithLeftAndRightChild()
        {
            int[] unsortedArray = { 3, 5, 4, 1, 2 };
            int[] sortedArray = { 1, 2, 4, 5 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(3));
            Assert.IsFalse(bst.Search(3));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }
    }
}
