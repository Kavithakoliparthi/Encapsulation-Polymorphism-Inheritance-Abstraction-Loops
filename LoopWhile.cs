using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LoopWhile
    {
        static void Main(string[] args)
        {
              Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = 1;
            while (n < 5)
            {
                Console.WriteLine(n);
                          Console.ReadLine();
                n++;
            }
        }
    }
}
