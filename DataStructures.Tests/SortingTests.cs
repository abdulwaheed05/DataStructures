using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemsAlgorithms;

namespace DataStructures.Tests
{

    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void BubbleSortIntegers()
        {
            Sorting<int> sorter = new Sorting<int>();
            int[] unsortedArray = {1, 4, 5, 2, 4, 3, 0, 9, 7};
            int[] toBeSortedArray = {1, 4, 5, 2, 4, 3, 0, 9, 7};

            sorter.BubbleSort(toBeSortedArray);

            Assert.AreEqual(unsortedArray.Length, toBeSortedArray.Length);

            Assert.IsTrue(Utilities.IsArraySorted(toBeSortedArray));

            foreach (var i in toBeSortedArray)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BubbleSortOneMillionIntegers()
        {
            Sorting<int> sorter = new Sorting<int>();

            int[] unSortedMillionItems = Utilities.RandomIntegerGenerator(1000000);

            sorter.BubbleSort(unSortedMillionItems);
        }
}
}
