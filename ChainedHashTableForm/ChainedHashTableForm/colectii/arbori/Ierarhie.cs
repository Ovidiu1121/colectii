using Colectii.colectii.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ChainedHashTableForm.colectii.arbori
{
    public class Ierarhie<T> where T : IComparable<T>
    {
        private TreeNode<T> root;
        private int rows = 0;

        public TreeNode<T> findByData(T data)
        {
          return find(this.root, data);
        }
        public TreeNode<T> Root
        {
            get { return this.root; }
            set { this.root = value; }
        }
        public int Rows
        {
            get { return this.rows; }
            set { this.rows = value; }
        }
        public Ierarhie(T data)
        {
            root=new TreeNode<T> (data);
        }
        public TreeNode<T> find(TreeNode<T> current, T data)
        {
            if (current == null)
            {
                return null;
            }
            else if (current.Data.Equals(data))
            {
                return current;
            }
            var left = find(current.Left, data);
            if (left!=null)
                return left;
            return find(current.Right, data);
        }
        public bool add(T manager, T subordonat)
        {
            TreeNode<T> manNode = find(root, manager);
            if (manNode == null)
            {
                Console.WriteLine("Nu exista managerul");
                return false;
            }
            if (manNode.Left != null && manNode.Right != null)
            {

                Console.WriteLine("Deja avem oameni pe pozitiile respective");
            }
            if (manNode.Left == null)
            {
                manNode.Left = new TreeNode<T>(subordonat);
            }
            else
            {
                manNode.Right = new TreeNode<T>(subordonat);
            }
            Console.WriteLine("Am adaugat "+  subordonat);
            return true;
        }
        public void afisare()
        {
            Coada<TreeNode<T>> coada = new Coada<TreeNode<T>>();
            coada.push(root);

            while (!coada.isEmpty())
            {
                TreeNode<T> node = coada.pop();
                Debug.WriteLine(node);
                if (node.Left != null)
                {
                    coada.push(node.Left);
                }
                if (node.Right != null)
                {
                    coada.push(node.Right);
                }
            }

        }
                            

    }
}
