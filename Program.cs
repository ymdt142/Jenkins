using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ProjectName
{
    internal class Program
    {
        static void Main(string[] args)
        {
//comment for testttt
//INCLIUDED LOG4NET
//this is for main with new pipeline
            Console.WriteLine("give value for a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result is "+(a+b));
            Console.ReadKey();
        }
    }
}
