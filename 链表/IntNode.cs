using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleApp1
{
    public class IntNode
    {
        public int data;
        public IntNode next;
        public IntNode(int data)
        {
            this.data = data;
        }
        public void append(int data)
        {
            var head = this;
            var newnode = new IntNode(data);
            while (head.next != null)
            {
                head = head.next;
            }
            head.next = newnode;
        }
        public void insert(IntNode node, int data)
        {     
            var currentNode = find(node);      
            if (currentNode == null)
            {
                return;
            }
            var newnode = new IntNode(data);          
            newnode.next = currentNode.next;
            currentNode.next = newnode;
          
        }
        public void ReverseNode(IntNode node)
        {//2473519
            if (node==null)
            {
                return;
            }
            List<IntNode> list = new List<IntNode>() { node};
            while (node.next!=null)
            {

                list.Add(node.next);
                node = node.next;
            }
            for (int i = list.Count-1; i >= 0; i--)
            {
                var head = list[i];
                if (i==0)
                {
                    head.next = null;
               
                }
                else
                {
                    head.next = list[i - 1];
                }
            }
            var hhh = list[list.Count-1];
        }

        public void ReverseList()
        {
         var   head = new IntNode(1);
            head.append(2);
            head.append(3);
            head.append(4);
       

            IntNode tmp1 = null;
            IntNode tmp2 = null;

            while (head != null)
            {//nest赋值给当前，当前赋值给下一个循环(当前next)的nest
                tmp2 = head.next;//save next head
                head.next = tmp1;
                tmp1 = head;
                head = tmp2;

            }
             head = new IntNode(1);
            head.append(2);
            head.append(3);
            head.append(4);

            // while (head!=null)
            // {
            ////     tmp1 = null;
            //     tmp1 = head.next;
            //     head.next.next = head;
            //     head = tmp1;
            // }
             
            //head.next = tmp2;
            //tmp2 = head;
            //head = tmp1;
            
            var n = tmp1;
           // return ;
        }
        public IntNode find(IntNode node)
        {
            var head = this;
            while (head.data!=node.data)
            {
                head = head.next;
            }
            return head;
        }
    }
}
