using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HpsProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                    
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("=---Pilih menu Aplikasi---=");
            Console.WriteLine("===========================");
            Console.WriteLine("\n1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");


            // PERINTAH: kode untuk menampilkan menu
        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
            produk.codeProduk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.namaProduk = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.HrgBeli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.HrgJual = Convert.ToInt32(Console.ReadLine());
            daftarProduk.Add(produk);

            // PERINTAH: collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HpsProduk()

        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data ");
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if(produk.codeProduk == kode)
                {
                    hapus = no;
                }
            }
            if (hapus !=1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            // PERINTAH: collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int noUrut = 0;
            Console.WriteLine("Data Produk");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}.Kode Produk: {1}, Nama Produk: {2}, Harga Jual: {4}", noUrut, produk.codeProduk, produk.namaProduk, produk.HrgBeli, produk.HrgJual);

            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");

            }
            // PERINTAH: collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
