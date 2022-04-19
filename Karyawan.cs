using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4392
{
    class Karyawan
    {
        public Karyawan(string nama, string nik, int gajibulanan)
        {
           Nik = nik;
           Nama = nama;
           GajiBulanan = gajibulanan;
        }
        //properties
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

    }

}
