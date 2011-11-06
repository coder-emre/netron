using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
namespace Sunucu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RemotingConfiguration.Configure("sunucu.config");
            Console.WriteLine("Telepler Dinleniyor !!!");
            Console.ReadLine();

        }
    }
}
