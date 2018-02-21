using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IfElseLaddder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<0||n>100)
            {
                Console.WriteLine("wrong number");
            }
            else if(n>=0&&n<50)
            {
                Console.WriteLine("fail");
                Console.ReadLine();
            }
            else if(n>=50 && n <60)
            {
                Console.WriteLine("D grade");
                Console.ReadLine();
            }
            else if(n>=60 && n<70)
            {
                Console.WriteLine("C grade");
                Console.ReadLine();
            }
            else if(n>=70&& n<80)
            {
                Console.WriteLine("B grade");
                Console.ReadLine();
            }
            else if(n>=80 && n<90)
            {
                Console.WriteLine("A grade");
                Console.ReadLine();
            }
        }
    }
}
