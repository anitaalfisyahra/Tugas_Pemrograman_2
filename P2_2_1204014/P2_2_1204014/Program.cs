using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204014
{
    class Program
    {
        static void Main(string[] args)
        {
            int hari, bulan, tahun;
            Console.Out.WriteLine("Menghitung umur...");
            Console.Out.WriteLine("==================");

            try
            {
                Console.Out.WriteLine("Masukkan tanggal: ");
                hari = Convert.ToInt32(Console.In.ReadLine());

                Console.Out.WriteLine("Masukkan bulan: ");
                bulan = Convert.ToInt32(Console.In.ReadLine());

                Console.Out.WriteLine("Masukkan tahun: ");
                tahun = Convert.ToInt32(Console.In.ReadLine());

                DateTime ultah = new DateTime(tahun, bulan, hari);
                DateTime hariini = DateTime.Now;

                TimeSpan umur = hariini.Subtract(ultah);
                Console.Out.WriteLine("Saat ini umur anda adalah: {0} hari, {1} jam, {2} menit", umur.Days, umur.Hours, umur.Minutes);
                Console.In.ReadLine();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Terjadi kesalahan \n " + e.Message);
                Console.In.ReadLine();
            }
        }

    }
}
