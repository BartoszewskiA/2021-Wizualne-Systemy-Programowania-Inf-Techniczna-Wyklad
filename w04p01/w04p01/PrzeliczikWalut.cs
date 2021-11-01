using System;
using System.Collections.Generic;
using System.Text;

namespace w04p01
{
    class PrzeliczikWalut
    {
        private double walutaPrzeliczeniowaPLN=0;
        private double kursEuro = 4.4;
        private double kursUSD = 4;
        public PrzeliczikWalut(){}
        public void setPLN(double kwota) { walutaPrzeliczeniowaPLN = kwota; }
        public void setEURO(double kwota) { walutaPrzeliczeniowaPLN = kwota * kursEuro; }
        public void setUSD(double kwota) { walutaPrzeliczeniowaPLN = kwota * kursUSD; }
        public double getPLN() { return walutaPrzeliczeniowaPLN; }
        public double getEURO() { return walutaPrzeliczeniowaPLN / kursEuro; }
        public double getUSD() { return walutaPrzeliczeniowaPLN / kursUSD; }
    }
}
