using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages // static ekelendiğinden newlemeden kullanabiliriz.Zaten sabit bir mesaj verceeğimizden newlemeye gerek yok direkt message..... seklinde kullanabiliriz.
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductsListed="Ürünler Listelendi";
    }
}
