using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public class Kitap
    {
        private string _YazarAd;
        private string _KitapAd;
        private double _BasimYil;
        private string _KitapTur;
        private double _ID;

        //public string KitapAdi { get; set; }
        //public string YazarAdi { get; set; }
        //public string KitapTuru { get; set; }
        //public int BasimYili { get; set; }

        public string YazarAd
        {
            get { return _YazarAd; }
            set
            {
                {
                    _YazarAd = value;
                }
            }
        }

        public string KitapAd
        {
            get { return _KitapAd; }
            set { _KitapAd = value; }
              
        }

        public double BasimYil
        {
            get { return _BasimYil; }
            set { _BasimYil = value; }
        }

        public string KitapTur
        {
            get { return _KitapTur; }
            set { _KitapTur = value; }
        }

        public double ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public Kitap() { }

        public void TabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {this.YazarAd,
                                         this.KitapAd,
                                         this.BasimYil,
                                         this.KitapTur,
                                         this.ID});
        }
    }
}