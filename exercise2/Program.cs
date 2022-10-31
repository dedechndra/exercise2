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
                // Pengguna memasukkan elemen pada array
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("<" + (i + 1) + "> ");
                    string s1 = Console.ReadLine();
                    dede[i] = Int32.Parse(s1);
                }
            }
        }

        private void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("------------ -----------------------");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("-----------------------------------");
            for (int dc = 0; dc < n; dc++)
            {
                Console.WriteLine(dede[dc]++);
            }
            Console.WriteLine("");
        }

        public void BubleSortArray()
        {
            for (int i = 1; i < n; i++) // for n-1 passes
            {
                // Pada pass i , bandingkan n - i elemen pertama dengan elemen selanjutnya 
                for (int dc = 0; dc < n - i; dc++)
                {
                    if (dede[dc] > dede[dc + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = dede[dc];
                        dede[dc] = dede[dc + 1];
                        dede[dc + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating the object of the Bubblesort class 
            Program myList = new Program();
            // Pemanggilan fungsi untuk menerima elemen array 
            myList.read();
            // Pemanggilan fungsi untuk menampilkan array 
            myList.BubleSortArray();
            //manggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
            Console.Read();

        }
    }
}


namespace QuickShort
{
    class Program
    {
        //array of integers to hold value
        private int[] dede = new int[26];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements

        //number of elements in array
        private int n;
        private int pivot;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 26)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 26 elements \n");

            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=======================");

            //get array elements 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dede[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index y

        void swap(int x, int y)
        {
            int temp;
            temp = dede[x];
            dede[x] = dede[y];
            dede[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int i, dc, k;
            if (low >= high)
                return;
            int mid = (low + high / 2);

            //Partition the list into two parts:
            // one containing elements less that or equal to pivot
            //Outher containning elements greather than pivot

            i = low;
            dc = mid + 1;
            k = low;

            //Partition the list into two parts:
            // one containing elements less that or equal to pivot
            //Outher containning elements greather than pivot

            i = low + 1;
            dc = high;

            pivot = dede[low];
        }  

    }

}



    
    



