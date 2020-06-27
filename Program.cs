using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.orderTest();
            tree.isvalid();
             // new sum().sum3();
             // 定义一个无参数、int类型返回值的委托
             //Func<int> func = () =>
             //{
             //    Thread.Sleep(2000);
             //    return DateTime.Now.Day;
             //};
             //// 输出委托同步调用的返回值
             //Console.WriteLine($"func.Invoke()={func.Invoke()}");
             //// 委托的异步调用
             //IAsyncResult asyncResult = func.BeginInvoke(p =>
             // {
             //     Console.WriteLine(p.AsyncState);
             // }, "异步调用返回值");
             //// 输出委托异步调用的返回值
             //Console.WriteLine($"func.EndInvoke(asyncResult)={func.EndInvoke(asyncResult)}");
             //new randombox().Compute();
             //new Bsearch().getindex();
             //new LIS().Get();
             //sort.quick_sort();
             //sort.mergeSort();
             //sort.insertSort();
             //Stack<int> st = new Stack<int>();
             //st.Push(1);
             //st.Push(3);
             //var aaa = st.Pop();
             //HashSet<int> hs = new HashSet<int>();
             //hs.Add(1);
             //hs.Remove(1);
             ////   new LIS().lis(new int[] { 2, 1, 6, 3, 5, 4, 8, 7, 9 });
             var node = new IntNode(2);
            node.append(4);
            node.append(7);
            node.append(3);
            node.append(1);
            node.append(9);
           // var newnode = new IntNode(3);
          //  node.insert(newnode, 5);
            node.ReverseList();
            Console.WriteLine("Hello World!");
        }
        private static void str(string a)
        {
            a = "2";
        }
        private static void int_(int a)
        {
            a = 5;
        }

        private async void ttt()
        {

            Console.WriteLine(1);
        }
    }
}
