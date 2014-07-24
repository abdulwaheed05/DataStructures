using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAlgorithms
{
   public class Sorting<T> where T : IComparable<T>
   {
       public void InsertionSort()
       {}

       public void BubbleSort(T[] array)
       {
           for (int i = 0; i < array.Length; i++)
           {
               for (int j = i+1; j < array.Length; j++)
               {
                   if (array[i].CompareTo(array[j]) > 0)
                   {
                       T temp = array[j];
                       array[j] = array[i];
                       array[i] = temp;
                   }
               }
           }
    }

       public void HeapSort()
       {}

       public void QuickSort()
       {
           
       }

       public void SelectionSort()
       {}

       public void MergeSort()
       {}
    }
}
