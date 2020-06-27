using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class sort
    {
        public static void insertSort()
        {

            int[] array = new int[] { 2, 4, 3, 1, 5 };
            //2 4 3 1 5
            for (int i = 1; i < array.Length; i++)
            {
                var value = array[i];
                var j = i - 1;
                for (; j >= 0; j--)
                {
                    if (array[j] > value)
                    {
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = value;
            }
        }

        public static void mergeSort()
        {
            int[] array = new int[] { 2, 4, 3, 1, 5 };
            mergesort_c(array, 0, array.Length - 1);
        }

        public static void mergesort_c(int[] array, int begin, int end)
        {
            if (begin >= end)
            {
                return;
            }
            var mid = (begin + end) / 2;
            mergesort_c(array, begin, mid);
            mergesort_c(array, mid + 1, end);
            merge(array, begin, mid, end);
        }
        public static void merge(int[] array, int first, int mid, int end)
        {
            int[] tmp = new int[end - first + 1];
            int m = first;
            int n = mid + 1;
            int k = 0;
            while (m <= mid && n < end)
            {
                if (array[m] < array[n])
                {
                    tmp[k] = array[m];
                    k++;
                    m++;
                }
                else
                {
                    tmp[k] = array[n];
                    k++;
                    m++;
                }
            }
            while (m <= mid)
            {
                tmp[k] = array[m];
                k++;
                m++;

            }
            while (n < end)
            {
                tmp[k] = array[n];
                k++;
                n++;
            }
            for (k = 0, m = first; m < end; k++, m++)
            {
                array[m] = tmp[k];
            }
        }


        // 快速排序，A是数组，n表示数组的大小
        public static void quick_sort()
        {
            int[] array = new int[] { 2, 4, 3, 1, 5 };
            quick_sort_c(array, 0, array.Length - 1);
        }
        // 快速排序递归函数，p,r为下标
        public static void quick_sort_c(int[] array, int first, int end)
        {
            if (first >= end) return;

            var q = partition(array, first, end); // 获取分区点
            quick_sort_c(array, first, q - 1);
            quick_sort_c(array, q + 1, end);
        }

        public static int partition(int[] array, int first, int end)
        {
            var pivot = array[end];

            var i = first;
            for (int j = first; j < end; j++)
            {
                if (array[j] < pivot)
                {
                    swap(array,i,j);
                    i=i+1;
                }
            }
              swap(array,i,end);

            return i;


        }
        public  static void swap(int[] array, int i, int j)
        {
            if (i == j) return;
            var tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}
