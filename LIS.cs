using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
   public  class LIS
    {
        #region 二分
        public void lis(int[] array)
        {//2, 1, 6, 3, 5, 4, 8, 7, 9
            int len = 1;
            int[] tmpArrary = new int[array.Length];
            tmpArrary[0] = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i] > tmpArrary[len - 1])
                {
                    tmpArrary[len] = array[i];
                    ++len;
                }
                else
                {
                    int pos = BiSearch(tmpArrary, len, array[i]);
                    tmpArrary[pos] = array[i];
                }
            }
        }
        public void lis1(int[] array)
        {
            int len = 1;
            int[] tmparray = new int[array.Length];
            tmparray[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > tmparray[len - 1])
                {
                    tmparray[len] = array[i];
                    ++len;
                }
                else
                {
                    int pos = BiSearch(tmparray, len, array[i]);
                    tmparray[len] = array[i];
                }
            }
        }
        public int BiSearch(int[] array, int length, int data)
        {
            int left = 0; int right = length - 1;
            int mid;
            HashSet<int> mids = new HashSet<int>();
            while (left <= right)
            {

                mid = left / 2 + right / 2;
                if (mids.Contains(mid))
                {
                    return left;
                }
                mids.Add(mid);

                if (array[mid] > data)
                {
                    right = mid - 1;

                }
                else if (array[mid] < data)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return left;
        }
        #endregion

        #region 动态规划
        public void Get()
        {
            int[] array = new int[] { 2, 1, 6, 3, 5, 4, 8, 7, 9 };
            var tmparray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                tmparray[i] = 1;

            }
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[j]>array[i]&&tmparray[j]<tmparray[i]+1)
                    {
                        tmparray[j] = tmparray[i] + 1;
                    }
                }
            }
            var max = tmparray.Max();
        }

        public void Get1()
        {
            int[] array = new int[] { 2, 1, 6, 3, 5, 4, 8, 7, 9 };
            var dparray = new int[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                dparray[i] = 1;

            }
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[j]>array[i]&&dparray[j]< dparray[i]+1)
                    {
                        dparray[j] = dparray[i] + 1;
                    }
                }
            }
            var result = dparray.Max();
        }
        #endregion
    }
}
