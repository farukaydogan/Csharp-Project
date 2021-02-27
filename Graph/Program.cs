using System;
using System.Collections;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
//sınıf nesnesi oluştılur ve yeni node gönderliri
            DirectedGraph liste = new DirectedGraph();
            liste.Add(new Node("A"));
            liste.Add(new Node("B"));
            liste.Add(new Node("C"));
            liste.Add(new Node("D"));
            liste.Add(new Node("E"));
            liste.Read();
            DirectedGraph library = new DirectedGraph();
            library.basaEkle("A");
//basa ekleme metdouna a gnderilir
        }
    }

    class DirectedGraph
    { //yeni nesne oluşturulur ve null parametreler sgönderilir
        private Node baslangic = null;
        private Node son = null;
        LinkedList<Node> liste = new LinkedList<Node>();
        //yeni düğüm oluşturur 
        public void Add(Node x)
        {
            Node yeniDugum = new Node(x.isim);
        }
        //basa ekle metoduna gelen yeni isim node classından yeni nesne oluşturulur adıda yeni elemandır yeni düğümün 
        //içerisinde baslangıç  ,son ve yeni düğümler bağlanır
        public void basaEkle(string yeniEleman)
        {
            Node yeniDugum = new Node(yeniEleman);
            yeniDugum.sonraki = baslangic;
            baslangic = yeniDugum;
            son = baslangic.sonraki;
        }
        //dügümlerin bağlanması için conect metoduna parametre ile gelen isim gönderilir
        public void connect(Node x)
        {
            son.isim = (x.isim);
        }
        //dügümlerin çözülmesi için sil metoduna parametre ile gelen isim gönderilir
        public void disconnect(Node x)
        {
            Sil(x.isim);
        }
        public Node Sil(String anahtar)
        {
            Node dugum = baslangic;
            Node onceki = baslangic;
            while (dugum.isim != anahtar)
            {
                if (dugum.sonraki == null)
                {
                    return null;
                }
                else
                {
                    onceki = dugum;
                    dugum = dugum.sonraki;
                }
                if (dugum == baslangic)
                {
                    baslangic = baslangic.sonraki;
                }
                else
                {
                    onceki.sonraki = dugum.sonraki;
                }
            }
            return dugum;
        }
        public void Read()
        {
            Console.WriteLine(liste.First.Value.isim);
        }
    }


    public class Node
    {
        //düğümün ismidir
        public string isim;
        // Kendinden sonraki eleman bilgisini verir.
        public Node sonraki;
        //yapıcı ile gelen veriyi isim stringine eşitler
        public Node(string gelenVeri)
        {
            isim = gelenVeri;
        }
    }


}
