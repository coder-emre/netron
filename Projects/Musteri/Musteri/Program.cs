using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("musteri.config");
            UzakNesne.magazalar mgz = new UzakNesne.magazalar();
            string YetkiliKisi = mgz.MagazaYetkili("Future Bikes");

            Console.WriteLine("Uzak Serverdan Bilgi Alındı : " + YetkiliKisi);
            Console.ReadLine();
        }
    }
}
