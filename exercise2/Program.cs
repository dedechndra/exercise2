using System;

namespace exercise2
{
    class Program
    {
        // Deklarasi array int dengan ukuran 06+20-2x15+10+20 = 26
        private int[] dede = new int[26];
        // Deklarasi variabel int untuk menyimpan banyaknya data pada array 
        private int n;
        // Fungsi / Method untuk menerima masukan 
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 26)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 26 elemen.\n");
                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine(" Masukkan elemen array ");
                Console.WriteLine("------------------------");
            }
        }
    }
}


