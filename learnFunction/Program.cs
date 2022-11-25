using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace learnFunction
{
    internal class Program
    {

        static void DigitCountSum(int num)
        {
            int count = 0, RaqamlarSum = 0, kerakliRaqam = 0;
            kerakliRaqam = num;
            while (num != 0)
            {
                RaqamlarSum += kerakliRaqam % 10;
                kerakliRaqam /= 10;
                num /= 10;
                count++;
            }

            Console.WriteLine($"raqamlar soni : {count}, raqamlari yigindisi : {RaqamlarSum}");
        }
        static void Main(string[] args)
        {
            int a;
            for (int i = 0; i < 3; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                DigitCountSum(a);
            }
            //Console.WriteLine(1/10);

        }
    }
}
