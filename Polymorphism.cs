//polymorphism
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Polymorphism
    {
        public float Add(float i,float j,float k)
        {
            return i + j + k;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    class Overload
    {
        static void Main(string[] args)
        {
            Polymorphism obj = new Polymorphism();
            Console.WriteLine("sum is:" + obj.Add(10, 20));
            Console.WriteLine("sum is:" + obj.Add(20.1f, 10.0f, 5.8f));
            Console.ReadLine();
        }
    }
}
