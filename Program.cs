using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(Console.WindowWidth / 2, Console.WindowHeight / 2);


            Console.WriteLine("tgl. lahir (hh/bb/tttt)");
            string sTgl = Console.ReadLine();

            string[] sArrTgl = sTgl.Split('/');

            string hh = sArrTgl[0];
            string bb = sArrTgl[1];
            string tttt = sArrTgl[2];

            // string dateString = "2025-09-20 14:00:00";
            string dateString = tttt + "-" + bb + "-" + hh;
            DateTime dateTime = DateTime.Parse(dateString);

            string hari = Hari((int)dateTime.DayOfWeek);            
            string shio = Shio(int.Parse(tttt));

            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("SHIO");
            Console.WriteLine("-------");
            Console.WriteLine("Hari lahir: " + hari);
            Console.WriteLine("Shio: " + shio);

            Console.ReadKey();
        }

        private static string Hari(int hari)
        {
            switch (hari)
            {
                case 0:
                    return "Minggu";
                case 1:
                    return "Senin";
                case 2:
                    return "Selasa";
                case 3:
                    return "Rabu";
                case 4:
                    return "Kamis";
                case 5:
                    return "Jumat";
                default:
                    return "Sabtu";
            }
        }


        private static int[] getTahun(int tahun)
        {
            int[] tanggal = new int[7];
            tanggal[0] = tahun;

            for (int i = 1; i < tanggal.Length; i++)
            {
                tahun = tahun + 12;
                tanggal[i] = tahun;
            }

            return tanggal;
        }



        private static string Shio(int tahunInput)
        {
            int[] tahunKuda = getTahun(1930);
            int[] tahunKambing = getTahun(1931);
            int[] tahunMonyet = getTahun(1932);
            int[] tahunAyam = getTahun(1933);
            int[] tahunAnjing = getTahun(1934);
            int[] tahunBabi = getTahun(1935);
            int[] tahunTikus = getTahun(1936);
            int[] tahunKerbau = getTahun(1937);
            int[] tahunMacan = getTahun(1938);
            int[] tahunKelinci = getTahun(1927);
            int[] tahunNaga = getTahun(1928);
            int[] tahunUlar = getTahun(1929);

            string hasil = "";

            if (tahunKuda.Contains(tahunInput)) hasil = "Kuda";
            else if (tahunKambing.Contains(tahunInput)) hasil = "Kambing";
            else if (tahunMonyet.Contains(tahunInput)) hasil = "Monyet";
            else if (tahunAyam.Contains(tahunInput)) hasil = "Ayam";
            else if (tahunAnjing.Contains(tahunInput)) hasil = "Anjing";
            else if (tahunBabi.Contains(tahunInput)) hasil = "Babi";
            else if (tahunTikus.Contains(tahunInput)) hasil = "Tikus";
            else if (tahunKerbau.Contains(tahunInput)) hasil = "Kerbau";
            else if (tahunMacan.Contains(tahunInput)) hasil = "Macan";
            else if (tahunKelinci.Contains(tahunInput)) hasil = "Kelinci";
            else if (tahunNaga.Contains(tahunInput)) hasil = "Naga";
            else if (tahunUlar.Contains(tahunInput)) hasil = "Ular";

            return hasil;
        }







    }
}
