//Encapsulation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
        int SId;
        string SName;
        int SAge;
        public void GetData()
        {
            Console.WriteLine("enter student details");
            this.SId = Convert.ToInt32(Console.ReadLine());
            this.SName = Console.ReadLine();
            this.SAge = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayData()
        { 
            Console.WriteLine("SId:" + this.SId);
            Console.WriteLine("SName" + this.SName);
            Console.WriteLine("SAge:" + this.SAge);
        }
    }
    class EStudent
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.GetData();
            obj.DisplayData();
            Console.ReadLine();
        }
    }
}
