using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Uygulaması
{
    public class Emanet
    {
        private double _kitapID;
        private double _sonTarih;
        private double _tc;

        public double kitapID
        {
            get { return _kitapID; ; }
            set { _kitapID = value; }
        }

        public double SonTarih
        {
            get { return _sonTarih; }
            set { _sonTarih = value; }
        }

        public double Tc
        {
            get { return _tc; }
            set { _tc = value; }
        }

        public Emanet() { }

        public void TabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {   this.kitapID,
                                            this.SonTarih,
                                            this.Tc,
                                                        });
        }
    }
}
