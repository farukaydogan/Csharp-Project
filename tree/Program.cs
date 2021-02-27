using System;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedtree linked = new linkedtree();

            Node node1 = new Node();
            node1.key = 37;
            Node node2 = new Node();
            node2.key = 37;
            linked.Add(node1,node2);
            Node node3 = new Node();
            node3.key = 20;

                








          //  node1.right.key = 32;
          //  node1.right.right.key = 38;

          //  node1.left.key = 12;
          //  node1.left.right.key =18;
          //  node1.left.left.key =4;
          //  node1.left.left.right.key = 7;
          //string x =  linked.search(35);
          //  Console.WriteLine(x);
            
        }
    }
}
