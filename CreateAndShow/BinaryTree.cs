using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree<k> where k : IComparable
    {
        public BinarySearchTreeNode<k> Root;

        public void AddNode(k Key )
        {
            Root = AddRecursively(Root, Key);
            
        }

        public k GetRoot { get { return Root.Key; } }

        public k GetRootLeft { get { return Root.Left.Key; } }

        public k GetRootRight { get { return Root.Right.Key; } }

        private BinarySearchTreeNode<k> AddRecursively(BinarySearchTreeNode<k> Current, k Key)
        {
            if (Current == null)
                return new BinarySearchTreeNode<k>(Key);

            int CompareResult = Key.CompareTo(Current.Key);

            if (CompareResult == 0)
                return Current;

            if (CompareResult < 0)
                Current.Left = AddRecursively(Current.Left, Key);
            else
                Current.Right = AddRecursively(Current.Right, Key);
            return Current;

        }
        public int GetSize()
        {
            return this.getSizeRecursively(Root);
        }

        private int getSizeRecursively(BinarySearchTreeNode<k> Current)
        {
            return Current != null ? 0 : 1 + this.getSizeRecursively(Current.Left)
                                           + this.getSizeRecursively(Current.Right);
        }

        //public bool SearchKey(k Key)
        //{
        //    return SearchRecursively(Root, Key);
        //}

        //private bool SearchRecursively(BinarySearchTreeNode<k> Current, k Key )
        //{
        //    if(Current==null)
        //        return false;
        //    if (Current.Key.CompareTo(Key) == 0)
        //        return true;
        //    else
        //        return SearchRecursively(Current.Left, Key) || SearchRecursively(Current.Right, Key);
 
        //}

        }
    }

