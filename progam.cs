using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrogaman2607
{
    class Karyawan
    {
        public string NIK(get; set;)
        public string Nama(get; set)
        public string GajiBulanan(get, set)

        public void GetData()
        {
            Console.WriteLine("No, NIK/Nama            Gaji Bulanan")
            Console.WriteLine()
        }

        public Karyawan(string nik, string nama; int gajibulanan)
        {
            NIK = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
            
            if(Gajibulanan,0)
            {
                Console.WriteLine("Gaji tidak boleh kurang dari 0");
                Gaji Bulanan = 0;
            }
        }
    }
}