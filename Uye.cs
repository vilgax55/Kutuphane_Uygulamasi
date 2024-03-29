using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Uygulaması
{
    public class Uye
    {
        private double _uyeTc;
        private string _uyeAdi;
        private string _uyeSoyadi;
        private double _uyeTel;

        public double UyeTc
        {
            get { return _uyeTc; }
            set { _uyeTc = value; }
        }

        public string UyeAdi
        {
            get { return _uyeAdi; }
            set { _uyeAdi = value; }
        }

        public string UyeSoyadi
        {
            get { return _uyeSoyadi; }
            set { _uyeSoyadi = value; }
        }

        public double UyeTelNo
        {
            get { return _uyeTel; }
            set { _uyeTel = value; }
        }

        public Uye() { }

        public void TabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {this.UyeTc,
                                         this.UyeAdi,
                                         this.UyeSoyadi,
                                         this.UyeTelNo,});
        }
    }
}
