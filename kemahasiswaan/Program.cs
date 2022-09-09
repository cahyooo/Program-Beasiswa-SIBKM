using System;

namespace kemahasiswaan
{
    class Program
    {
        string nama, nim, fakultas, prodi,status,nope;
        int pilihan,cek2,smt;
        float ipk,gaji;
        Boolean cek = true;
        static void Main(string[] args)
        {
            Program objek = new Program();
            Console.WriteLine("\t\t\tMahasiswa Penerima Beasiswa \t\t\t");
            Console.Write("Nama \t\t\t: ");
            objek.nama = Console.ReadLine();

            Console.Write("NIM \t\t\t: ");
            objek.nim = Console.ReadLine();
            Console.WriteLine(" ");

            while (objek.cek) {
                
                Console.WriteLine("Fakultas");
                //
                Console.WriteLine("1. Fakultas Teknologi Informasi");
                Console.WriteLine("2. Fakultas Teknik");
                Console.WriteLine(" ");
                Console.Write("Fakultas \t\t\t: ");
                objek.pilihan = int.Parse(Console.ReadLine());

                if (objek.pilihan == 1) {
                    objek.fakultas = "Fakultas Teknologi Informasi";
                    objek.cek = false;
                    objek.cek2 = 1;

                }
                else if(objek.pilihan == 2)
                { 
                    objek.fakultas = "Fakultas Teknik";
                    objek.cek = false;
                    objek.cek2 = 2;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Pilihan Yang Anda Masukan Salah");
                    Console.WriteLine(" ");
                    objek.cek = true;

                }

            }
            objek.cek = true;
            //objek.pilihan = 0;
            while (objek.cek)
            {
                Console.WriteLine("");
                Console.WriteLine("Program Studi");

                if (objek.cek2 == 1)
                {
                    
                    Console.WriteLine("1. Teknik Informatika");
                    Console.WriteLine("2. Sistem Informasi");
                    Console.WriteLine("3. Sistem Komputer");

                    Console.WriteLine(" ");
                    Console.Write("Program Studi \t\t\t: ");
                    objek.pilihan = int.Parse(Console.ReadLine());
                    if (objek.pilihan == 1)
                    {
                        objek.prodi = "Teknik Informatika";
                        objek.cek = false;
                    }
                    else if (objek.pilihan == 2)
                    {
                        objek.prodi = "Sistem Informasi";
                        objek.cek = false;
                    }
                    else if (objek.pilihan == 3)
                    {
                        objek.prodi = "Sistem Komputer";
                        objek.cek = false;
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Pilihan Yang Anda Masukan Salah");
                        Console.WriteLine(" ");
                        objek.cek = true;
                    }
                }
                else if (objek.cek2 == 2)
                {
                    Console.WriteLine("1. Teknik Sipil");
                    Console.WriteLine("2. Teknik Industri");
                    Console.WriteLine(" ");
                    Console.Write("Program Studi \t\t\t: ");
                    objek.pilihan = int.Parse(Console.ReadLine());
                    if (objek.pilihan == 1)
                    {
                        objek.prodi = "Teknik Sipil";
                        objek.cek = false;
                    }
                    else if (objek.pilihan == 2)
                    {
                        objek.prodi = "Teknik Industri";
                        objek.cek = false;
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Pilihan Yang Anda Masukan Salah");
                        Console.WriteLine(" ");
                        objek.cek = true;
                    }

                }
            }

            Console.Write("No Handphone \t\t\t: ");
            objek.nope = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Semester \t\t\t: ");
            objek.smt = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("IPK \t\t\t\t: ");
            objek.ipk = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Pendapatan Orang Tua \t\t: Rp. ");
            objek.gaji = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (objek.ipk >= 4.0)
            {
                objek.status = "Penerima";
            }
            else if (objek.ipk < 4.0 && objek.gaji > 2000000)
            {
                objek.status = "Bukan Penerima";

            }

            else if (objek.gaji <= 2000000 && objek.ipk >= 3.5)
            {
                objek.status = "Penerima";
            }

            //else if (objek.gaji >= 2000000 && objek.ipk < 3.5)
            //{
            //    objek.status = "Bukan Penerima";
            //}

            else
            {
                objek.status = "Bukan Penerima";

            }

            // Output
            Console.WriteLine("\t\t\t----------Data Mahasiswa----------\t\t\t");

            Console.WriteLine("");
            Console.WriteLine("Nama Mahasiswa\t\t : "+ objek.nama);
            Console.WriteLine("NIM\t\t\t : " + objek.nim);
            Console.WriteLine("Fakultas\t\t : "+ objek.fakultas);
            Console.WriteLine("Program Studi\t\t : " + objek.prodi);
            Console.WriteLine("No Handphone\t\t : " + objek.nope);
            Console.WriteLine("Semester\t\t : " + objek.smt);
            Console.WriteLine("IPK\t\t\t : " + objek.ipk);
            Console.WriteLine("Pendapatan Orangtua\t : Rp. " + objek.gaji+",-");
            Console.WriteLine("Status Beasiswa\t\t : " +objek.status);

        }

    }
}
