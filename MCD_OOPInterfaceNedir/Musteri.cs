using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceNedir
{
    public class Musteri : IMusteri
    {
        int id;
        string isim, soyisim;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }

        public int KayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("Kayıt düzenlendi..");
            return 1;
        }

        public int KayitSil(int id)
        {
            Console.WriteLine("Kayıt silindi..");
            return 1;
        }

        public int YeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Yeni kayıt eklendi..");
            return 1;
        }
    }
}
