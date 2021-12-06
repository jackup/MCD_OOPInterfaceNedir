using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceNedir
{
    public interface IMusteri
    {
        //public IMusteri()
        //{
        // Interface içerisinde constructor kullanılamaz.
        //}


        //Field
        int Id { get; set; }
        string Isim { get; set; }
        string Soyisim { get; set; }


        //Metod
        int YeniKayit(string isim, string soyisim);
        int KayitDuzenle(int id, string isim, string soyisim);
        int KayitSil(int id);


    }
}
