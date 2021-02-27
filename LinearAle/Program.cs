using System;

namespace LinearAle
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matri1 = new Matrix(3, 3);
            Matrix matri2 = new Matrix(3, 3);
            int sayac = 1;
            int sayac2 = 9;
            for (int i = 0; i < matri1.ColCount; i++)
            {
                for (int j = 0; j < matri1.RowCount; j++)
                {
                    matri1.matris[i, j] = sayac;
                    matri2.matris[i, j] = sayac2;
                    sayac++;sayac2--;
                }
            }
          matri1=  matri1 + matri2;
            matri1.Print();
           matri1= matri1.Transpose();
            matri1.Print();
        }
    }

    class Matrix
    {
         public int colCount;
          public int rowCount;
        public int[,] matris;
        public int[] matris2;
        public int ColCount
        {
            get { return colCount;}
            set { colCount = value; }
        }
        public int RowCount
        {
            get { return rowCount; }
            set { rowCount = value; }
        }
        public int this[int i, int j]
        {
            get { return matris[i, j]; }
            set { matris[i, j] = value; }
        }
        public Matrix (int x, int y) { ColCount = x; RowCount = y;matris = new int[ColCount, RowCount]; }
        public Matrix (int x) { ColCount = x; matris2 = new int[ColCount]; }
        public static Matrix operator +(Matrix x, Matrix y)
        {
            Matrix yeni = new Matrix(x.ColCount, x.RowCount);
            for (int i = 0; i < x.ColCount; i++)
            {
                for (int j = 0; j < x.RowCount; j++)
                {
                    yeni.matris[i, j] = x.matris[i, j] + y.matris[i, j];
                }
            }
            return yeni;
        }
        public static Matrix operator -(Matrix x, Matrix y)
        {
            Matrix yeni = new Matrix(x.ColCount, x.RowCount);
            for (int i = 0; i < x.ColCount; i++)
            {
                for (int j = 0; j < x.RowCount; j++)
                {
                    yeni.matris[i, j] = x.matris[i, j] - y.matris[i, j];
                }

            }
            return yeni;

        }
        public static Matrix operator /(Matrix x, Matrix y)
        {
            Matrix yeni = new Matrix(x.ColCount, x.RowCount);
            for (int i = 0; i < x.ColCount; i++)
            {
                for (int j = 0; j < x.RowCount; j++)
                {
                    yeni.matris[i, j] = x.matris[i, j] / y.matris[i, j];
                }

            }
            return yeni;
        }
        public static Matrix operator *(Matrix x, Matrix y)
        {
            Matrix yeni = new Matrix(x.ColCount, x.RowCount);
            for (int i = 0; i < x.ColCount; i++)
            {
                for (int j = 0; j < x.RowCount; j++)
                {
                    yeni.matris[i, j] = x.matris[i, j] * y.matris[i, j];
                }

            }
            return yeni;
        }
        public static Matrix operator *(Matrix x, int y)
        {
            for (int i = 0; i <x.ColCount; i++)
            {
                for (int j = 0; j < x.RowCount; j++)
                {
                    x.matris[i, j] *= y;
                }
            }
            return x;
        }
        public Matrix Transpose()
        {
            Matrix sonuc = new Matrix(ColCount, RowCount);
            for (int i = 0; i < ColCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    sonuc.matris[j, i] = matris[i, j];
                }
            }
            return sonuc;
           
        }
        public void Print()
        {
            for (int i = 0; i < ColCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    class Vector
    {

    }
}
