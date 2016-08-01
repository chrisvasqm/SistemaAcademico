using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(10, 2));
            Console.ReadKey();
        }
        private static byte GetSum(byte firstValue, byte secondValue)
        {
            var result = (byte)firstValue + (byte)secondValue;
            return (byte)result;
        }
    }
}
