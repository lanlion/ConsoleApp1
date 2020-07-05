using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// 树
    /// </summary>
    public class TreeNode
    {
        public int val;
        public IList<TreeNode> children = new List<TreeNode>();
        List<int> res = new List<int>();
        public TreeNode()
        {

        }

        public TreeNode(int _val)
        {
            val = _val;
        }

        public TreeNode(int _val, IList<TreeNode> _children)
        {
            val = _val;
            children = _children;
        }
        public IList<int> Preorder(TreeNode root)
        {

            if (root == null)
            {
                return res;
            }
            res.Add(root.val);
            foreach (var item in root.children)
            {
                Preorder(item);
            }
            return res;
        }
        public IList<int> Preorder1(TreeNode root)
        {
            //     1
            // 3   2   4
            //5  6
            List<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            Stack<TreeNode> st = new Stack<TreeNode>();
            st.Push(root);

            while (st.Count != 0)
            {
                var tmpnode = st.Pop();
                res.Add(tmpnode.val);
                if (tmpnode.children != null)
                {
                    for (int i = tmpnode.children.Count - 1; i >= 0; i--)
                    {
                        st.Push(tmpnode.children[i]);
                    }
                }
            }

            return res;
        }
      



        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int ans = 0;
            while (left < right)
            {
                ans = Math.Max(ans, (right - left) * Math.Min(height[left], height[right]));
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return ans;
        }
    }

   
}
