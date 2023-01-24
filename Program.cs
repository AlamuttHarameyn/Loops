using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16_Cevrimler
{
    class Program
    {
        //döngülerde başlangıç ifadesi olur.Döngüler başladığı yere geri gelir
        //
        static void Main(string[] args)
        {
            int i = 0;
            int sayac = 0;
            while (i < 10) //iken anlamına gelir.
                //i küçüktür 10dan olduğu için çıktı 9a kadar olur.
            {
                sayac++;
                Console.WriteLine(i);//debug nedir, debug hata ayıklama,
            //hata tespiti ya da kod blogunun nasıl çalıştığını
            //izlemektir. bizim amacımız i'nin değişimini izlemek
                i++;
            }
            
            Console.WriteLine("Döngü Sonu.");
            Console.ReadKey();
        }
    }
}
