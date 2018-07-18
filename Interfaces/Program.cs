using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Transakcje t1 = new Transakcje("01", "25/03/2011", 331);
            Transakcje t2 = new Transakcje("01", "11/02/2015", 3321);
            t1.WyswietlDane();
            t2.WyswietlDane();
            Console.ReadKey();
        }
        public interface ITransakcje
        {
            void WyswietlDane();
            int PoliczIlosc();
        }
        public class Transakcje : ITransakcje
        {
            private string kod;
            private string data;
            private int ilosc;

            public Transakcje()
            {
                kod = string.Empty;
                data = string.Empty;
                ilosc = 0;
            }
            public Transakcje(string kodIn, string dataIn, int iloscIn)
            {
                kod = kodIn;
                data = dataIn;
                ilosc = iloscIn;
            }
            public int PoliczIlosc()
            {
                return ilosc;
            }
            public void WyswietlDane()
            {
                Console.WriteLine("Kod: {0}", kod);
                Console.WriteLine("Data: {0}", data);
                Console.WriteLine("Ilość: {0}", ilosc);
            }
        }
    }
}
