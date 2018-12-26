using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Solution
    {
        public static void quicksort (int[] array)
        {
            quicksort(array, 0, array.Length - 1);
        }

        public static void quicksort(int[] array, int left, int right)
        {
            if (left >= right)                                                  // if these indexies are out of order
            {
                return;
            }
            int pivot = array[(left + right) / 2];          // pick the pivot. picks the middle.
            int index = partition(array, left, right, pivot);  // 
            quicksort(array, left, index - 1);
            quicksort(array, index, right);

            
                }
        public static int partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)           // move from left to right side, moving pointers closer to each other. 
            {
                while (array[left] < pivot)             // move up until a number is found lower than the pivot
                {
                    left++;
                }
                while (array[right] > pivot)            //move down until a number is found higher than the index
                {
                    right--;
                }

                if(left <= right)               //swap the numbers
                {
                    swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
