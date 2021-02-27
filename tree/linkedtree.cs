using System;
using System.Collections.Generic;
using System.Text;

namespace tree
{
    class linkedtree
    {
        private Node root = new Node();
        public Node Root { get => root; set { root = value; } }

        public String search(int key) {

            Node n = searchTree(root, key);
            return n == null ? null : n.data;
        }

        private Node searchTree(Node root, int key)
        {
            if (root == null)
            {
                return null;
            }
            else if (key == root.key)
            {
                return root;
            }
            else if(key>root.key){ return searchTree(root.right,key); }
            else { return searchTree(root.left,key); }
        }
        public void Add(Node x,Node y)
        {
            if (x == null)
            {
                Console.WriteLine("boştur ekledim");
                x.key = y.key;
            }

            else if (x.key >= y.key)
            {
                Console.WriteLine("aranan kan bulundu");
               Add(x.right,y);
            }
            else
            {
                Console.WriteLine("Nisa <3");
                Add(x.left, y);
            }
            
        }
    }
}
