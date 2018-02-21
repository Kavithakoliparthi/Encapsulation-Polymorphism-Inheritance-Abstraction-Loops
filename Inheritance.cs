//Single Inheritance  and multi level inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Inheritance
    {
        int BCode;
        string BName;
        string BAddress;
        public void GetBData()
        {
            Console.WriteLine("enter branch details");
            this.BCode = Convert.ToInt32(Console.ReadLine());
            this.BName = Console.ReadLine();
            this.BAddress = Console.ReadLine();
        }
        public void DisplayBData()
        {
            Console.WriteLine("the branch details are:");
            Console.WriteLine("branch code is:" + this.BCode);
            Console.WriteLine("branch name is:" + this.BName);
            Console.WriteLine("branch address is:" + this.BAddress);
        }
    }
    class EmployeeInheritance : Inheritance
    {
        int EId;
        string EName;
        string EAddress;
        int EAge;
        public void GetEData()
        {
            Console.WriteLine("enter emp details");
            this.EId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress=Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine()); 
        }
        public void DisplayEData()
        {
            Console.WriteLine("the emloyee details are");
            Console.WriteLine("Emp Id is:" + this.EId);
            Console.WriteLine("Emp Name is:" + this.EName);
            Console.WriteLine("Emp Address is:" + this.EAddress);
            Console.WriteLine("Emp Age is:" + this.EAge);
        }
    }
    //Single Inheritance
    /*
    class clsInheritance
    {
        static void Main(string[] args)
        {
            EmployeeInheritance obj = new EmployeeInheritance();
            obj.GetBData();
            obj.GetEData();
            obj.DisplayBData();
            obj.DisplayEData();
            Console.ReadLine();
        }
    }
    */
     /* MultiLevel Inheritance  */
    class Salary : EmployeeInheritance
    {
        double Basic, DA, HRA,Grass;
        public void GetSalary()
        {
            Console.WriteLine("enter basic salary");
            this.Basic = Convert.ToDouble(Console.ReadLine());
        }
        public void calculate()
        {
            this.DA = Basic * 0.03;
            this.HRA = Basic * 0.3;
            this.Grass = Basic + DA + HRA;
        }
        public void DisplaySalaryData()
        {
            Console.WriteLine("employee details are:");
            Console.WriteLine("basic salary is:" + this.Basic);
            Console.WriteLine("DA salary is:" + this.DA);
            Console.WriteLine("HRA salary is:" + this.HRA);
            Console.WriteLine("Grass salary is:" + this.Grass);
        }
    }
    class clsInheritance
    {
        static void Main(string[] args)
        {
            Salary obj = new Salary();
            obj.GetBData();
            obj.GetEData();
            obj.GetSalary();
            obj.calculate();
            obj.DisplayBData();
            obj.DisplayEData();
            obj.DisplaySalaryData();
            Console.ReadLine();
        }
    }
    
  }
