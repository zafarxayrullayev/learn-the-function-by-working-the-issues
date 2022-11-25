using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace learnFunction
{
    internal class Program
    {
        // 123  --> 321
        static void InvertDigit(int num)
        {
            int teskariRaqam;
            teskariRaqam = num;
            while(num != 0)
            {
                Console.Write(teskariRaqam % 10);
                teskariRaqam/= 10;
                num /= 10;
            }
            Console.WriteLine("\n");
        }
        
        static void Main(string[] args)
        {
            int num;
            for (int i = 0; i < 3; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                InvertDigit(num);
            }
        }
    }
}
