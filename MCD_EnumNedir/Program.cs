using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.musteriNumara = "MSN001";
            M1.isim = "Gamze";
            M1.soyisim = "Kural";
            M1.emailAdres = "GamzeKural98@gmail.com";

            SanalDataBase SB = new SanalDataBase();
            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            int enumInt = (int)musteriReturnValue.kayitBasarili;
            Console.WriteLine(enumInt);

            Console.ReadLine();
        }
    }
}
