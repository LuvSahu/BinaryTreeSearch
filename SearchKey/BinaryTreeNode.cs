using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTreeNode<k>
    {
        public k Key;
        public BinarySearchTreeNode<k> Right;
        public BinarySearchTreeNode<k> Left;

        public BinarySearchTreeNode(k key)
        {
            this.Key = key;
            Right = null;
            Left = null;
        }
       
    }
   
}

