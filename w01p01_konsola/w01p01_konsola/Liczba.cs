using System;
using System.Collections.Generic;
using System.Text;

namespace w01p01_konsola
{
    class Liczba
    {
        protected int x;
        public Liczba(int wartosc=0)
        {
            x = wartosc;
        }

        public void setLiczba(int wartosc) { x = wartosc; }
        public int getLiczba() { return x; }
    }
}
