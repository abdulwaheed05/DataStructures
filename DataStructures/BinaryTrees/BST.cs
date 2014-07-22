using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DataStructures.BinaryTrees
{
    /// <summary>
    ///  A BST is a binary tree where nodes are ordered in the following way
    ///     1. Each Node contains one key (also known as data)
    ///     2. The keys in the left subtree are less then the key in its parent node. L less than P
    ///     3. The keys in the right subtree are greater then the key in its paraent node. P less than R
    ///     4. Duplicate keys are not allowed 
    /// </summary>
    public class BST<T> where T : IComparable<T>
    {
        private Node<T> rootNode;

        public BST()
        {
            this.rootNode = null;
        }

        public void Insert(T data)
        {
            if (this.rootNode == null)
            {
                rootNode = new Node<T>(data);
                return;
            }

            InsertRecursive(data, this.rootNode);
        }

        public bool Search(T data)
        {
            return SearchRecursive(data, this.rootNode);
        }

        public List<T> Traverse(TreeTraversalType traversalType)
        {
            switch (traversalType)
            {
                case TreeTraversalType.PreOrder:
                    return PreOrderTraversal();
                    break;

                case TreeTraversalType.InOrder:
                    return InOrderTraversal();
                    break;

                case TreeTraversalType.PostOrder:
                    return PostOrderTraversal();
                    break;

                case TreeTraversalType.LevelOrder:
                    return LevelOrderTraversal();
                    break;

                default:
                    return InOrderTraversal();
            }
        }

        public bool DeleteNode(T data)
        {
            if (this.rootNode == null)
            {
                return false;
            }

            // Find the node first, keep reference to parent
            Node<T> current = this.rootNode;
            Node<T> parent = null;
            int result = current.Data.CompareTo(data);

            while (result != 0)
            {
                if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    parent = current;
                    current = current.Left;
                }

                if (current == null)
                {
                    return false;
                }

                result = current.Data.CompareTo(data);
            }

            if (current.Right == null)
            {
                if (parent == null)
                {
                    this.rootNode = current.Left;
                }
                else
                {
                    if (parent.Left == current)
                    {
                        parent.Left = current.Left;
                    }
                    else
                    {
                        parent.Right = current.Left;
                    }
                }
            }

            else if (current.Right.Left == null)
            {
                if (parent == null)
                {
                    this.rootNode = current.Right;
                }
                else
                {
                    if (parent.Left == current)
                    {
                        parent.Left = current.Right;
                    }
                    else
                    {
                        parent.Right = current.Right;
                    }
                }            
            }
            else
            {
                // Find successor for this node
                Node<T> successorParent = current.Right;
                Node<T> tempNode = successorParent.Left;

                while (tempNode.Left != null)
                {
                    successorParent = tempNode;
                    tempNode = tempNode.Left;
                }

                successorParent.Left = successorParent.Right;
                tempNode.Left = current.Left;
                tempNode.Right = current.Right;

                if (parent == null)
                {
                    this.rootNode = tempNode;
                }
                else
                {
                    if (parent.Left == current)
                    {
                        parent.Left = tempNode;
                    }
                    else
                    {
                        parent.Right = tempNode;
                    }
                }
            }

            return true;
        }

        private bool SearchRecursive(T data, Node<T> parentNode)
        {
            if (parentNode == null)
            {
                return false;
            }

            if (parentNode.Data.CompareTo(data) == 0)
            {
                return true;
            }
            else if (parentNode.Data.CompareTo(data) == 1)
            {
                return SearchRecursive(data, parentNode.Left);
            }
            else
            {
                return SearchRecursive(data, parentNode.Right);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<T> PostOrderTraversal()
        {
            List<T> dataList = new List<T>();

            PostOrderTraversalRecursive(this.rootNode, dataList);

            return dataList;
        }

        private void PostOrderTraversalRecursive(Node<T> node, List<T> dataList)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left != null)
            {
                PostOrderTraversalRecursive(node.Left, dataList);
            }

            if (node.Right != null)
            {
                PostOrderTraversalRecursive(node.Right, dataList);
            }

            dataList.Add(node.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<T> InOrderTraversal()
        {
            List<T> dataList = new List<T>();

            InOrderTraversalRecursive(this.rootNode, dataList);

            return dataList;
        }

        private void InOrderTraversalRecursive(Node<T> node, List<T> dataList)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left != null)
            {
                InOrderTraversalRecursive(node.Left, dataList);
            }

            dataList.Add(node.Data);

            if (node.Right != null)
            {
                InOrderTraversalRecursive(node.Right, dataList);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<T> PreOrderTraversal()
        {
            List<T> dataList = new List<T>();

            PreOrderTraversalRecursive(this.rootNode, dataList);

            return dataList;
        }

        private void PreOrderTraversalRecursive(Node<T> node, List<T> dataList)
        {
            if (node == null)
            {
                return;
            }

            dataList.Add(node.Data);

            if (node.Left != null)
            {
                InOrderTraversalRecursive(node.Left, dataList);
            }

            if (node.Right != null)
            {
                InOrderTraversalRecursive(node.Right, dataList);
            }
        }

        private List<T> LevelOrderTraversal()
        {
            List<T> nodeList = new List<T>();

            if (this.rootNode == null)
            {
                return nodeList;
            }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(this.rootNode);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                nodeList.Add(node.Data);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            return nodeList;
        }

        private void InsertRecursive(T data, Node<T> parentNode)
        {
            if (parentNode == null)
                throw new InvalidOperationException("parentNode cannot be null");

            if (parentNode.Data.Equals(data))
                throw new InvalidOperationException("duplicates are not allowed in BST");

            if (parentNode.Data.CompareTo(data) == 1)
            {
                if (parentNode.Left != null)
                {
                    InsertRecursive(data, parentNode.Left);
                }
                else
                {
                    parentNode.Left = new Node<T>(data);
                }
            }
            else if (parentNode.Data.CompareTo(data) == -1)
            {
                if (parentNode.Right != null)
                {
                    InsertRecursive(data, parentNode.Right);
                }
                else
                {
                    parentNode.Right = new Node<T>(data);
                }
            }
        }
    }
}
