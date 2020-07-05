using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1
{/// <summary>
/// 二叉树
/// </summary>
    public class BinaryTree
    {
         List<int> list = new List<int>();
         BTreeNode root;
        public BinaryTree()
        {//          3
            //    1      5 
            //  0   2
            BTreeNode left = new BTreeNode(1);
            left.lchild = new BTreeNode(0);
            left.rchild = new BTreeNode(2);
            BTreeNode right = new BTreeNode(5);
            root = new BTreeNode(3, left, right);
        }
        /// <summary>
        /// 中序
        /// </summary>
        /// <param name="tmp"></param>
        public void inorder(BTreeNode tmp)
        {
            if (tmp == null)
            {
                return;
            }

            inorder(tmp.lchild);
            list.Add(tmp.data);
            inorder(tmp.rchild);

        }
        /// <summary>
        /// 后序
        /// </summary>
        /// <param name="tmp"></param>
        public void postorder(BTreeNode tmp)
        {
            if (tmp == null)
            {
                return;
            }

            postorder(tmp.lchild);
            postorder(tmp.rchild);
            list.Add(tmp.data);

        }
        /// <summary>
        /// 前序
        /// </summary>
        /// <param name="tmp"></param>
        public void preorder(BTreeNode tmp)
        {
            if (tmp == null)
            {
                return;
            }
            list.Add(tmp.data);
            preorder(tmp.lchild);
            preorder(tmp.rchild);


        }
        public void orderTest()
        { 
            
            list.Clear();
            preorder(root);
           
            Console.WriteLine("前序" + string.Join(",",this. list));
             list.Clear();
            inorder(root);
            Console.WriteLine("中序" + string.Join(",", list));
            list.Clear();
            postorder(root);
            Console.WriteLine("后序" + string.Join(",", list));

        }
        /// <summary>
        /// 判断是不是二叉搜索树
        /// </summary>
        public void isvalid()
        {
            //1：中序遍历打印 完是个升序的集合
            list.Clear();
            inorder(root);
            var newlist = new List<int>(list) ;
            newlist.Sort();

            bool isok = string.Join(",", list) == string.Join(",", newlist);
            
        }
        public int MaxDepth(BTreeNode root)
        {
            if (root == null) return 0;
            Queue<BTreeNode> tmpqueue = new Queue<BTreeNode>();
            tmpqueue.Enqueue(root);
            int depth = 0;
            while (tmpqueue.Count != 0)
            {
                int size = tmpqueue.Count;
                for (int i = 0; i < size; i++)
                {
                    BTreeNode temp = tmpqueue.Dequeue();
                    if (temp.lchild != null)
                    {
                        tmpqueue.Enqueue(temp.lchild);
                    }
                    if (temp.rchild != null)
                    {
                        tmpqueue.Enqueue(temp.rchild);
                    }
                }
                depth++;
            }
            return depth;
        }
    }
    public class BTreeNode
    {
        public int data { get; set; }

        public BTreeNode lchild { get; set; }

        public BTreeNode rchild { get; set; }

        public BTreeNode()
        {
        }

        public BTreeNode(int data)
        {
            this.data = data;
        }

        public BTreeNode(int data, BTreeNode lchild, BTreeNode rchild)
        {
            this.data = data;
            this.lchild = lchild;
            this.rchild = rchild;
        }



    }
}
