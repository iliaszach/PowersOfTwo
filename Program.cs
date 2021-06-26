using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var square = PowersOfTwo(1);       

        }
        public static BigInteger[] PowersOfTwo(int n)
        {
            return Enumerable.Range(0, n + 1).Select(num => new BigInteger(Math.Pow(2.0,num))).ToArray();
        }


        public static BigInteger[] PowersOfTwo2(int n)
        {
            return Enumerable.Range(0, n + 1).Select(x =>  BigInteger.Pow(2,x)).ToArray();
        }


        public static BigInteger[] PowersOfTwo3(int n)
        {
            return (from x in Enumerable.Range(0, n + 1)
                    select BigInteger.Pow(2, x)).ToArray();
        }

    }
}
