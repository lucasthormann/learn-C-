using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Int size: ");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine();
            string textBigNumber = "900000000";
            long bigNumeber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumeber);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Long size: ");
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine();
            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Double size: ");
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine();
            string textPrecision = "-5.0000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Float size: ");
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine();
            string textMoney = "214.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Decimal size: ");
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            Console.ReadLine();
        }
    }
}
