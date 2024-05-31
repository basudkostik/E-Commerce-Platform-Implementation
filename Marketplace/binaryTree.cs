using System;
using System.Collections.Generic;
using System.Linq;

namespace Marketplace
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public int Count { get; private set; }

        public class Node
        {
            public marketItem Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(marketItem data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public void Insert(marketItem data)
        {
            if (Root == null)
            {
                Root = new Node(data);
            }
            else
            {
                InsertRec(Root, new Node(data));
            }
            Count++;
        }

        private void InsertRec(Node root, Node newNode)
        {
            if (newNode.Data.CompareTo(root.Data) < 0)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertRec(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    InsertRec(root.Right, newNode);
                }
            }
        }

        public void Delete(marketItem data)
        {
            Root = DeleteRec(Root, data);
        }

        private Node DeleteRec(Node root, marketItem data)
        {
            if (root == null)
                return root;

            if (data.CompareTo(root.Data) < 0)
                root.Left = DeleteRec(root.Left, data);
            else if (data.CompareTo(root.Data) > 0)
                root.Right = DeleteRec(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = MinValue(root.Right);
                root.Right = DeleteRec(root.Right, root.Data);
            }
            return root;
        }

        private marketItem MinValue(Node node)
        {
            marketItem minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }
            return minValue;
        }

        public void InOrder(Node node, List<marketItem> result)
        {
            if (node != null)
            {
                InOrder(node.Left, result);
                result.Add(node.Data);
                InOrder(node.Right, result);
            }
        }

        public void PreOrder(Node node, List<marketItem> result)
        {
            if (node != null)
            {
                result.Add(node.Data);
                PreOrder(node.Left, result);
                PreOrder(node.Right, result);
            }
        }

        public void PostOrder(Node node, List<marketItem> result)
        {
            if (node != null)
            {
                PostOrder(node.Left, result);
                PostOrder(node.Right, result);
                result.Add(node.Data);
            }
        }

        public int GetDepth(Node node)
        {
            if (node == null)
                return 0;

            int leftDepth = GetDepth(node.Left);
            int rightDepth = GetDepth(node.Right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }

        public int GetElementCount(Node node)
        {
            if (node == null)
                return 0;

            return 1 + GetElementCount(node.Left) + GetElementCount(node.Right);
        }

        public int GetLevel(Node node, marketItem data, int level = 1)
        {
            if (node == null)
                return 0;

            if (node.Data.Equals(data))
                return level;

            int downlevel = GetLevel(node.Left, data, level + 1);
            if (downlevel != 0)
                return downlevel;

            downlevel = GetLevel(node.Right, data, level + 1);
            return downlevel;
        }

        public List<marketItem> FindByCategory(string category)
        {
            var result = new List<marketItem>();
            FindByCategoryRec(Root, category, result);
            return result;
        }

        private void FindByCategoryRec(Node node, string category, List<marketItem> result)
        {
            if (node != null)
            {
                if (node.Data.Category == category)
                {
                    result.Add(node.Data);
                }
                FindByCategoryRec(node.Left, category, result);
                FindByCategoryRec(node.Right, category, result);
            }
        }

        public void Balance()
        {
            var nodes = new List<marketItem>();
            InOrder(Root, nodes);
            Root = BuildBalancedTree(nodes, 0, nodes.Count - 1);
        }

        private Node BuildBalancedTree(List<marketItem> nodes, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            var node = new Node(nodes[mid])
            {
                Left = BuildBalancedTree(nodes, start, mid - 1),
                Right = BuildBalancedTree(nodes, mid + 1, end)
            };
            return node;
        }
    }
}
