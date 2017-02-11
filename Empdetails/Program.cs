using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empdetails
{
    class mygen<T>
    {
        public T Add(T num1, T num2)
        {
            dynamic value1 = num1;
            dynamic value2 = num2;
            return value1 + value2;
        }
    }
    public class Employee
    {
        public string fname;
        public string lname;
        public int employeeid;
        public int SSN;

    }
    public class Fulltimeemp : Employee
    {
       public double salary;
        public DateTime hiredate;
        
        
    }
    public class Contractemp: Employee
    {
        public  DateTime hiredate;
        public DateTime enddate;
        public double hourlypay;

    }
    class Employeee
    {
        public void employeeseelcted()
        {

            Console.WriteLine("PLease select the employee\n1.Full time\n2.Contract employee");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:

                    Console.WriteLine("You have seleected full time");
                    Fulltimeemp femp = new Fulltimeemp();
                    Console.WriteLine("Please enter the first name of employee");
                    femp.fname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter the last name of employee");
                    femp.lname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter the employee id of employee");
                    femp.employeeid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the SSN of employee");
                    femp.SSN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the salary of employee");
                    femp.salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the hire date of employee");
                    femp.hiredate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("First name:" + femp.fname);
                    Console.WriteLine("last name" + femp.lname);
                    Console.WriteLine("Employee ID" + femp.employeeid);
                    Console.WriteLine("SSN" + femp.SSN);
                    Console.WriteLine("salary" + femp.salary);
                    Console.WriteLine("Hiring date" + femp.hiredate);
                    break;

                case 2:

                    Console.WriteLine("You have selected Contract employee");
                    Contractemp cemp = new Contractemp();
                    Console.WriteLine("Please enter the first name of employee");
                    cemp.fname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter the last name of employee");
                    cemp.lname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter the employee id of employee");
                    cemp.employeeid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the SSN of employee");
                    cemp.SSN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the hire date of employee");
                    cemp.hiredate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Please enter the end date of employee");
                    cemp.hiredate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Please enter the hourly of employee");
                    cemp.hourlypay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("First name:" + cemp.fname);
                    Console.WriteLine("last name" + cemp.lname);
                    Console.WriteLine("Employee ID" + cemp.employeeid);
                    Console.WriteLine("SSN" + cemp.SSN);
                    Console.WriteLine("End date" + cemp.enddate);
                    Console.WriteLine("Hiring date" + cemp.hiredate);
                    Console.WriteLine("Hourly pay" + cemp.hourlypay);
                    break;
            }
        }
        
        
        public static void Main(string[] args)
        {

                Employeee emp = new Employeee();
                emp.employeeseelcted();
                mygen<Int32> x = new mygen<int>();
                int val = x.Add(30, 20);
            Console.WriteLine("Result is:" + val);
                Console.Read();


        }
 }
}

