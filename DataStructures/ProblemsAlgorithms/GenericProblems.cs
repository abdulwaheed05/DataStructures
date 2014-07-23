using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAlgorithms
{
    public class GenericProblems
    {
        /// <summary>
        /// Closest pair – Given a set of n numbers, how do you find the pair of numbers
        /// that have the smallest difference between them? Once the numbers are sorted,
        /// the closest pair of numbers must lie next to each other somewhere in sorted
        /// order. Thus, a linear-time scan through them completes the job, for a total
        /// of O(n log n) time including the sorting.
        /// </summary>
        public void FindClosestPairOfNumbers()
        {
        }

        /// <summary>
        /// Element uniqueness – Are there any duplicates in a given set of n items?
        /// This is a special case of the closest-pair problem above, where we ask if there
        /// is a pair separated by a gap of zero. The most efficient algorithm sorts the
        /// numbers and then does a linear scan though checking all adjacent pairs.
        /// </summary>
        public void ElementUniqueness()
        {
        }

        /// <summary>
        /// Frequency distribution – Given a set of n items, which element occurs the
        /// largest number of times in the set? If the items are sorted, we can sweep
        /// from left to right and count them, since all identical items will be lumped
        /// together during sorting.
        /// To find out how often an arbitrary element k occurs, look up k using binary
        /// search in a sorted array of keys. By walking to the left of this point until the
        /// first the element is not k and then doing the same to the right, we can find
        /// this count in O(log n + c) time, where c is the number of occurrences of k.
        /// Even better, the number of instances of k can be found in O(log n) time by
        /// using binary search to look for the positions of both k −  and k +  (where
        ///  is arbitrarily small) and then taking the difference of these positions.
        /// </summary>
        public void FrequencyDistribution()
        {
        }

        /// <summary>
        /// Selection – What is the kth largest item in an array? If the keys are placed
        /// in sorted order, the kth largest can be found in constant time by simply
        /// looking at the kth position of the array. In particular, the median element
        /// (see Section 14.3 (page 445)) appears in the (n/2)nd position in sorted order.
        /// </summary>
        public void Selection()
        {
        }
    }
}
