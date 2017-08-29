using System;
using System.Collections.Generic;

namespace ST.Models.ViewModels
{
    public class SepetViewModel
    {
        public int FirmaId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime IstenilenTarih { get; set; }
        public string KullaniciId { get; set; }
        public int OdemeTipiId { get; set; }
        public List<FirmaUrunKategoriViewModel> Urunler { get; set; }
    }
}
