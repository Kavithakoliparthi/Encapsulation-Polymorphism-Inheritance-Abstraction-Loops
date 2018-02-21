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
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("it is even number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("not a even number");
                Console.ReadLine();
            }
        }
    }
}
