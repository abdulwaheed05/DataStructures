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
            Assert.IsNull(bst.Search(2));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
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
            Assert.IsNull(bst.Search(1));

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
            Assert.IsNull(bst.Search(5));

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
            int[] unsortedArray = { 3, 5, 4, 1, 2, 6 };
            int[] sortedArray = { 1, 2, 3, 4, 6 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(5));
            Assert.IsNull(bst.Search(5));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteNodeWithLeftAndRightChildRightChildHasLeft()
        {
            int[] unsortedArray = { 3, 5, 4, 1, 2, 8, 7 };
            int[] sortedArray = { 1, 2, 3, 4, 7, 8 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(5));
            Assert.IsNull(bst.Search(5));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteNodeWithLeftAndRightChildRightChildHasTwoLeftChildren()
        {
            int[] unsortedArray = { 3, 5, 4, 1, 2, 9, 8, 7 };
            int[] sortedArray = { 1, 2, 3, 4, 7, 8, 9};

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsNotNull(bst.Search(5));
            Assert.IsTrue(bst.DeleteNode(5));
            Assert.IsNull(bst.Search(5));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteRootWhenTreeIsEmpty()
        {
            BST<int> bst = new BST<int>();

            Assert.IsNull(bst.Search(0));
            Assert.IsFalse(bst.DeleteNode(0));
        }

        [TestMethod]
        public void DeleteRootNodeWithLeftAndRightChild()
        {
            int[] unsortedArray = { 3, 5, 4, 1, 2 };
            int[] sortedArray = { 1, 2, 4, 5 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(3));
            Assert.IsNull(bst.Search(3));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteRootNodeWithLeftChildOnly()
        {
            int[] unsortedArray = { 3, 2 };
            int[] sortedArray = { 2 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(3));
            Assert.IsNull(bst.Search(3));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }

        [TestMethod]
        public void DeleteRootNodeWithRightChildOnly()
        {
            int[] unsortedArray = { 3, 5 };
            int[] sortedArray = { 5 };

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            Assert.IsTrue(bst.DeleteNode(3));
            Assert.IsNull(bst.Search(3));

            var inOrderTraversal = bst.Traverse(TreeTraversalType.InOrder).ToArray();

            Assert.AreEqual(sortedArray.Length, inOrderTraversal.Length);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], inOrderTraversal[i]);
            }
        }
    }
}
