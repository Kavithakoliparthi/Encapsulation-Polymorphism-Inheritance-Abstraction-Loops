//polymorphism overriding
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Overriding
    {
        protected int EId;
        protected string EName;
        string EAddress;
        int EAge;
        public virtual void GetEmpData()
        {
            Console.WriteLine("enter employee details");
            this.EId= Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress=Console.ReadLine();
            this.EAge=Convert.ToInt32(Console.ReadLine());
         }
        public virtual void DispalyEmpData()
        {
            Console.WriteLine("the employee details are:");
            Console.WriteLine("EmpId :" +this.EId);
            Console.WriteLine("EmpName:" +this.EName);
            Console.WriteLine("EmpAddress:" +this.EAddress);
            Console.WriteLine("EmpAge:" +this.EAge);
        }
    }
    class Override : Overriding
    {
        Double Bonus;
        public override void GetEmpData()
        {
            Console.WriteLine("enter manager details");
            this.EId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.Bonus=Convert.ToInt32(Console.ReadLine());
        }
        public override void DispalyEmpData()
        {
            Console.WriteLine("the manager details are:");
            Console.WriteLine("EmpId is :" + this.EId);
            Console.WriteLine("EmpName is:" + this.EName);
            Console.WriteLine("EmpBonus is:" + this.Bonus);
        }
    }
    class FunctionOverride
    {
        static void Main(string[] args)
        {
            Override obj = new Override();
            obj.GetEmpData();
            obj.DispalyEmpData();
            Console.ReadLine();
        }
    }
}

/* 
 * virtual funtion means
 * if the methods are iverrided in sub class then the super class 
 * methods are declared as  virtual 
 * virtual is a keyword
 */