﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTrees
{
    /// <summary>
    ///  A BST is a binary tree where nodes are ordered in the following way
    ///     1. Each Node contains on key (also known as data)
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

        public void DeleteNode(T data)
        {
            throw new NotImplementedException();
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
            else if(parentNode.Data.CompareTo(data) == 1)
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
            throw new NotImplementedException();
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