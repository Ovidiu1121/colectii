using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.colectii.arbori
{
    public class TreeNode<T> : IComparable<TreeNode<T>> where T : IComparable<T>
    {
        private T data;
        private TreeNode<T> left;
        private TreeNode<T> right;

        public TreeNode(T data)
        {
            this.data = data;
            this.left=this.right=null;
        }
        public TreeNode()
        {
            this.left=this.right=null;
        }
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public TreeNode<T> Left
        {
            get { return this.left; }
            set { this.left = value; }
        }
        public TreeNode<T> Right
        {
            get { return this.right; }
            set { this.right = value; }
        }

        public int CompareTo(TreeNode<T> other)
        {
            return 1;
        }
        public override string ToString()
        {
            return data.ToString();
        }


    }
}
