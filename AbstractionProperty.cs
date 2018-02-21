//Abstraction
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class AbstractionProperty
    {
        static void Main(string[] args)
        {
            Abstraction obj = new Abstraction();
            Console.WriteLine("Enter Emp details");
            obj.PEId = Convert.ToInt32(Console.ReadLine());
            obj.PEName = Console.ReadLine();
            obj.PEAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the emp details are:");
            Console.WriteLine("EmpId is:" + obj.PEId);
            Console.WriteLine("EmpName is:" + obj.PEName);
            Console.WriteLine("EmpAge is:" + obj.PEAge);
            Console.ReadLine();
        }
    }
}
