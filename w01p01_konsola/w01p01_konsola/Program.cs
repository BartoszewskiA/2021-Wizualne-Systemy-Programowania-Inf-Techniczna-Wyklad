using System;

namespace w01p01_konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var x = 10.0;
            //napiszCos();

            var naszaLiczba = new Liczba(23);
            var innaLiczba = new DwieLiczby(20, 40);

            Console.WriteLine(naszaLiczba.getLiczba());
        
        }

        static void napiszCos()
        {
            Console.WriteLine("COŚ");
        }

    }
}
