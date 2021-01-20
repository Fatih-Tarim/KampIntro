using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naving convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: "+ urun.Adi);
        }
        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunadi);
        }
    }
}
