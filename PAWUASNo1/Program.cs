using System;

namespace PAWUASNo1
{
    //Membuat public class
    public class Soalno1
    {
        public void soalno1()
        {
            {
            awal:
                //Membuat tampilan awal data
                Console.WriteLine("==============================================");
                Console.WriteLine("    Selamat Datang di Administrasi Sekolah    ");
                Console.WriteLine("  Mohon Mengisi Data Dengan Sebenar-benarnya  ");
                Console.WriteLine("==============================================");
                Console.WriteLine();
                Console.WriteLine("============== Pendataan Siswa ==============");
                //Mengisi berapa jumlah data yang akan diisi
                Console.Write("Masukkan Jumlah Siswa Yang Akan di Data : ");
                string[][] strArray = new string[Convert.ToInt32(Console.ReadLine())][];
                int length = 6;
                for (int index1 = 0; index1 < strArray.Length; ++index1)
                {
                    strArray[index1] = new string[length];
                    for (int index2 = 0; index2 < strArray[index1].Length; ++index2)
                    {
                        switch (index2)
                        {
                            case 0:
                                //Memasukkan nama siswa
                                Console.Write("Masukkan Nama Siswa : ");
                                strArray[index1][index2] = Console.ReadLine();
                                break;
                            case 1:
                                //Memasukkan Nomor Induk Siswa
                                Console.Write("Masukkan Nomor Induk Siswa : ");
                                strArray[index1][index2] = Console.ReadLine();
                                break;
                            case 2:
                                //Memasukkan Jenis Kelamin Siswa
                                Console.Write("Masukkan Jenis Kelamin Siswa : ");
                                strArray[index1][index2] = Console.ReadLine();
                                break;
                            case 3:
                                //Memasukkan Alamat Siswa
                                Console.Write("Masukkan Alamat Siswa : ");
                                strArray[index1][index2] = Console.ReadLine();
                                break;
                            case 4:
                                //Memasukkan Kelas Siswa
                                Console.Write("Masukkan Kelas Siswa : ");
                                strArray[index1][index2] = Console.ReadLine();
                                break;
                            default:
                                //Memasukkan Nama Wali Kelas
                                Console.Write("Masukkan Nama Wali Kelas : ");
                                strArray[index1][index2] = Console.ReadLine();
                                Console.WriteLine();
                                break;
                        }
                    }
                }
                //Membuat Hasil Data yang akan ditampilkan
                Console.WriteLine();
                Console.WriteLine("============================================");
                Console.WriteLine("Berikut Hasil Pendataan Administrasi Siswa");
                Console.WriteLine("============================================");
                Console.WriteLine("Nama Siswa \t Nomor Induk \t Jenis Kelamin \t Alamat \t Kelas \t Nama Wali Kelas");
                for (int index1 = 0; index1 < strArray.Length; ++index1)
                {
                    for (int index2 = 0; index2 < strArray[index1].Length; ++index2)
                        Console.Write(string.Format("{0}         ", (object)strArray[index1][index2]));
                    Console.WriteLine();
                }
                Console.ReadKey();
                //kembali ke awal
                goto awal;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //memanggil kelas
            Soalno1 soall = new Soalno1();
            soall.soalno1();
        }
    }
}