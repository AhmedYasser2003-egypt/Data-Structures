using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
    internal class BSTNode
    {
        public int data;

        public BSTNode left;

        public BSTNode right;

        public BSTNode(int _data, BSTNode _left, BSTNode _right)
        {
            data = _data;
            left = _left;
            right = _right;
        }

        public BSTNode(int _data) : this(_data, null, null)
        { }


    }
    internal class BSTree
    {
        private BSTNode root;

        public BSTree()
        {
            root = null;
        }

        public void insert(BSTNode node)
        {
            if (root == null)
            {
                root = node;
                return;
            }

            BSTNode curr = root;
            while (curr != null)
            {
                if (curr.data >= node.data)
                {
                    if (curr.left != null)
                        curr = curr.left;
                    else
                    {
                        curr.left = node;
                        break;
                    }
                }
                else
                {
                    if (curr.right != null)
                        curr = curr.right;
                    else
                    {
                        curr.right = node;
                        break;
                    }
                }


            }

        }
        public void insert(int data)
        {
            insert(new BSTNode(data));
        }

        #region delete and it's sub function
        public void delete(int val)
        {
            if (root == null)
                return;

            if (root.data == val)
            {
                root = helper(root);
                return;
            }

            BSTNode curr = root;
            while (curr != null)
            {
                if (curr.data > val)
                {
                    if (curr.left != null && curr.left.data == val)
                    {
                        curr.left = helper(curr.left);
                        break;
                    }
                    else
                    {
                        curr = curr.left;
                    }
                }
                else
                {
                    if (curr.right != null && curr.right.data == val)
                    {
                        curr.right = helper(curr.right);
                        break;
                    }
                    else
                    {
                        curr = curr.right;
                    }
                }
            }
            
        }
        private BSTNode helper(BSTNode node) 
        {
            if (node.left == null)
                return node.right;
            if (node.right == null)
                return node.left;
            BSTNode rightChild = node.right;
            BSTNode lastRight = findLastRight(node.left);
            lastRight.right = rightChild;
            return node.left;
        }
        private BSTNode findLastRight(BSTNode node)
        {
            if (node.right == null)
                return node;
            return findLastRight(node.right);
        }
        #endregion

        private bool search(int val,BSTNode node)
        {
            if (node == null)
                return false;
            if (node.data == val)
                return true;
            else if (node.data > val)
                return search(val, node.left);
            else
                return search(val, node.right);
        }
        public bool search(int val)
        {
            return search(val, root);
        }


        public List<List<int>> BFS()
        {
            List<List<int>> result = new List<List<int>>();

            Queue<BSTNode> q = new Queue<BSTNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                List<int> level = new List<int>();
                int size = q.Count;
                for (int i = 0;i < size; i++)
                {
                    BSTNode node = q.Peek();
                    q.Dequeue();

                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                    level.Add(node.data);
                }
                result.Add(level);
            }

            return result;
        }

        public void printBST()
        {
            List<List<int>> result = BFS();

            for (int i = 0;i < result.Count;i++)
            {
                for (int j = 0;j < result[i].Count;j++)
                {
                    Console.Write($"{result[i][j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
