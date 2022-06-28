using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_PRA
{
    class Employee
    {
        protected int employeeId;
        protected string fullName;
        protected float salary;
        protected bool taxDeducted;

        public Employee(int employeeId, string fullName, float salary, bool taxDeducted)
        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.salary = salary;
            this.taxDeducted = taxDeducted;

        }

        public Employee(int employeeId, string fullName, float salary)
        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.salary = salary;
            this.taxDeducted = true;
        }

        public float GetNetSalary()
        {
            double netsalary;
            if (this.taxDeducted == true)
            {
                netsalary = salary * 0.8;
            }
            else
            {
                netsalary = salary;
            }
            return Convert.ToSingle(netsalary);
            

        }

        public void printInformation()
        {
            Console.WriteLine(employeeId + "," + "earns" + GetNetSalary() + "per month");
        }
    }

    class WeeklyEmployee: Employee
    {
        public WeeklyEmployee(int employeeId, string fullName, float salary, bool taxDeducted)
            : base(employeeId, fullName, salary, taxDeducted) { }
        public WeeklyEmployee(int employeeId, string fullName, float salary)
            : base(employeeId, fullName, salary) { }
        public new float GetNetSalary()
        {
            double netWeeklySalary;
            netWeeklySalary = (salary * 12) / 52;
            double netsalaryweekly;
            if (this.taxDeducted == true)
            {
                netsalaryweekly = netWeeklySalary * 0.8;
            }
            else
            {
                netsalaryweekly = netWeeklySalary;
            }
            return Convert.ToSingle(netsalaryweekly);
        }
        public new void printInformation()
        {
            Console.WriteLine(employeeId + "," + fullName + "earns" + GetNetSalary() + "per week");
        }

    }

}
