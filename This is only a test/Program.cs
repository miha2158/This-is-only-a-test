using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace This_is_only_a_test
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowWidth += 20;


            float f = 1.2345f;
            var binF = BitConverter.GetBytes(f).Select(c => Convert.ToString(c, 2).PadLeft(8,'0'));
            WriteLine("{0}\n",string.Join("",binF));

            double dou = 1.2345;
            var binDou = BitConverter.GetBytes(dou).Select(c => Convert.ToString(c, 2).PadLeft(8, '0'));
            WriteLine("{0}\n", string.Join("", binDou));

            //decimal dec1 = 4294967296 * 2;
            //decimal dec1 = decimal.Divide(decimal.MaxValue, 8589934592) + .0m;
            decimal dec1 = 0.00000000000000000000000000009m;
            //decimal dec1 = decimal.Multiply(decimal.Divide(decimal.MaxValue, 8589934592) + .5m, 2);
            //decimal dec1 = ulong.MaxValue + 1.1111m;
            //decimal dec1 = 1.23456789m;
            var binDec1 = decimal.GetBits(dec1).Select(c => Convert.ToString(c, 2).PadLeft(32, '0'));
            binDec1 = binDec1.Reverse();

            WriteLine("{0}\n", string.Join(" ", binDec1));
            WriteLine("{0}\n", dec1);

            //decimal dec2 = -dec1;
            decimal dec2 = 4135792468.0123456789098765432m;
            var binDec2 = decimal.GetBits(dec2).Select(c => Convert.ToString(c, 2).PadLeft(32, '0'));
            binDec2 = binDec2.Reverse();

            WriteLine("{0}\n", string.Join(" ", binDec2));
            WriteLine("{0}\n", dec2);



            ReadKey(true);
        }
    }
}
