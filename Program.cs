using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4392
{
    class Program
    {
        static void Main(string[] args)
        {
            //object gaji1 dan gaji2
            Karyawan gaji1 = new Karyawan("190302123", "Paijo", 3000000);
            Karyawan gaji2 = new Karyawan("190302124", "Jono", 2000000);
            if(gaji1.GajiBulanan < 0)
            {
                gaji1.GajiBulanan = 0;
            }
            if(gaji2.GajiBulanan < 0)
            {
                gaji2.GajiBulanan = 0;
            }
            Console.WriteLine("No \tNik/Nama \t\tGajiBulanan");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", gaji1.Nik, gaji1.Nama, gaji1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t{2}", gaji2.Nik, gaji2.Nama, gaji2.GajiBulanan);
            Console.WriteLine("Gaji 10%!! ");
            Console.WriteLine("\n");
            if(gaji1.GajiBulanan > 0 )
            {
                gaji1.GajiBulanan += gaji1.GajiBulanan * 10 / 100;
            }
            if(gaji2.GajiBulanan > 0)
            {
                gaji2.GajiBulanan += gaji2.GajiBulanan * 10 / 100;
            }
            Console.WriteLine("========KENAIKAN GAJI 10%========");
            Console.WriteLine("");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", gaji1.Nik, gaji1.Nama, gaji1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t{2}", gaji2.Nik, gaji2.Nama, gaji2.GajiBulanan);
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
