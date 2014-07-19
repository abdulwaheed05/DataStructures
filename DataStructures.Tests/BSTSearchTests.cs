using System;
using System.Linq;
using DataStructures.BinaryTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class BSTSearchTests
    {
        [TestMethod]
        public void SearchIntegers()
        {
            int[] unsortedArray = {3, 5, 4, 1, 2};
            int[] nonInsertedItems = {9, 8, 7, 21};

            BST<int> bst = new BST<int>();

            foreach (var item in unsortedArray)
            {
                bst.Insert(item);
            }

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Assert.IsTrue(bst.Search(unsortedArray[i]));
            }

            foreach (var nonInsertedItem in nonInsertedItems)
            {
                Assert.IsFalse(bst.Search(nonInsertedItem));
            }
        }
    }
}
