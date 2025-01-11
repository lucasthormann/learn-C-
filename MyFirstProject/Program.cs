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

            /* string textAge = "23";
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
             Console.WriteLine(decimal.MinValue);*/


            /*string textNum = Console.ReadLine();
            int num = Convert.ToInt32(textNum);
            if(num < 18)
            {
                Console.WriteLine("You are not an adult yet!!");
            }
            else
            {
                Console.WriteLine("You are an adult because you are " + num + " years old!");
            }

            Console.Write("Enter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("It's Monday!");
                    break;

                case 2: Console.WriteLine("It's Tuesday!");
                    break;

                case 3: Console.WriteLine("It's Wednesday!");
                    break;

                case 4: Console.WriteLine("It's Thursday!");
                    break;

                case 5: Console.WriteLine("It's Friday!");
                    break;

                case 6: Console.WriteLine("It's Saturday!");
                    break;

                case 7: Console.WriteLine("It's Sunday!");
                    break;

                default: Console.WriteLine("Invalid Input!");
                    break;

            }

            //conditional operator
            string result = day >= 8 || day <= 0 ? "Invalid" : "Valid";
            Console.WriteLine(result);
            Console.ReadLine();*/


            /*bool success = true;

            while (success)
            {
                Console.WriteLine("Enter a number: ");
                string numInput = Console.ReadLine();

                if(int.TryParse(numInput, out  int num)) {
                    success = false;
                    Console.WriteLine(num);

                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }

            }
            Console.ReadLine();*/
            /*Console.WriteLine("Enter an integer value: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/

            Console.WriteLine("Enter your message: ");
            string message = Console.ReadLine();

            for(int i = message.Length-1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }

        }
    }
}
