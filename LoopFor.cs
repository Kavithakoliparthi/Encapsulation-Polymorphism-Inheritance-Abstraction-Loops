using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LoopFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
