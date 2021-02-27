using System;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] dizi = { 1, 2, 3, 4};
            Linked link = new Linked(dizi);
            link.Add(5);
            link.Print();
           bool ara= link.Search(5);
           bool ara2= link.Search(6);
            link.Remove(5);
            link.Print();
        }
    }
}
