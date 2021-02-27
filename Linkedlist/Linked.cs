using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
    class Linked
    {
        Node Head = new Node();
        Node Tail = new Node();
        public Linked(byte[] x)
        {
            Node[] nodes = new Node[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                Node node = new Node() { Name = (byte)(i + 1) };
                nodes[i] = node;
            }
            for (int i = 0; i < x.Length - 1; i++)
            {
                nodes[i].next = nodes[i + 1];
            }
            Head = nodes[0];
            Tail = nodes[x.Length - 1];
            nodes[x.Length - 1].next = Head;
        }
        public void Print()
        {
            Node x = Head;
            Console.WriteLine(x.Name);
            x = x.next;
            while (x != Head)
            {
                Console.WriteLine(x.Name);
                x = x.next;
            }
        }
        public void Add(byte x)
        {
            Node node = new Node() { Name = x };
            Tail.next = node;
            node.next = Head;
            Tail = node;
        }
        public void Remove(byte x)
        {
           bool arama= Search(x);
            Node temp = Head;
            Node hed = Head;
            if (!arama)
            {
                Console.WriteLine("silinemedi");
            }
            else
            {
                if (Head.Name==x)
                {

                    Console.WriteLine("eleman siliniyor");
                    Tail.next = Head.next;
                }
                else
                {
                   hed= hed.next;
                    while (hed!=Head&&hed.Name!=x)
                    {
                        hed = hed.next;
                        temp = temp.next;
                    }
                    temp = hed.next;
                    Console.WriteLine("eleman silind");
                }
            }
        }
        public bool Search(byte x)
        {
            Node node = new Node();
            node = Head;
            if (node.Name==x)
            {
                Console.WriteLine(x + " bulundu");

                return true ;
            }
            node=node.next;
            while (node!=Head)
            {
                if (node.Name==x)
                {
                    Console.WriteLine(x+" bulundu");
                    return true;
                }
                node = node.next;
            }
            Console.WriteLine(x+" bulunamadı");
            return false;
        }
    }
}
