using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Execute.start();
        }
    }
    public class Execute
    {
        public static void start()
        {
            Console.WriteLine("testing from Execute class\n");
            for (int i = 1; i < 6; i++)
            {
                Console.Write(remainder(10,i) + " ");
                Console.Write(parity(10, i) + "\n");
            }
            Console.ReadLine();
        }
        private static int remainder(int bigInt, int littleInt)
        {
            return littleInt % bigInt;
        }
        private static string parity(int bigInt, int littleInt)
        {
            bool odd = false;
            if ((littleInt % bigInt) % 2 > 0)
            {
                odd = true;
            }
            return odd ? "odd" : "even";
        }
    }
}
