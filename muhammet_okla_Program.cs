using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ur_fiyati,kargo_ucreti, toplama;
            Console.Write("ürün fiyatı : "); 
            ur_fiyati = double.Parse(Console.ReadLine());

            if (ur_fiyati >= 100)
            {
                Console.WriteLine("kargo ücretsiz");
            } 
            else if(ur_fiyati < 100) 
            {
                kargo_ucreti = 5;
                toplama = ur_fiyati + kargo_ucreti;
                Console.WriteLine("kargoya  5'Tl fazla alınacak " + ":" + toplama);
            }

            Console.ReadKey();  
        }
    }
}
