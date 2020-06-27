using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp1
{
    public class sum
    {
        /// <summary>
        /// 数组里三个元素加起来=某个数
        /// [-1,0,1,2,-1,-4]  和为0
        /// </summary>
        public void sum3()
        {
            int[] arr = new int[] { -1, 0, 1, 2, -1, -4 };
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                dic[arr[i]] = i;
            }
            HashSet<int> hs = new HashSet<int>(arr);
            List<string> res = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    var tmp = -arr[i] - arr[j];
                    if (dic.ContainsKey(tmp))
                    {
                        res.Add($"{i},{j},{dic[tmp]}");
                    }
                }
            }

            var a = res;
        }
    }
}
