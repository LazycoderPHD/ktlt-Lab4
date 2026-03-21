using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktlt_Lab4
{
    public class Staff : Person
    {
        private string department;
        private double salary;

        public Staff() : base() { }
        public Staff(string name, int birthYear, string address, string department, double salary)
            : base(name, birthYear, address)
        {
            this.department = department;
            this.salary = salary;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter department: ");
            department = Console.ReadLine()!;
            Console.Write("Enter salary: ");
            salary = double.Parse(Console.ReadLine()!);
        }

        public override string ToString()
        {
            //return $"Staff[{base.ToString()} - Department: {department}, Salary: {salary}]";
            return $"“Staff[ {base.ToString()}[Name: {name}, Age: {birthYear}, Address: {address}] - Department:\r\n{department}, Salary: {salary}]";
        }

        public void UpdateSalary(double salary)
        {
            this.salary = salary;
        }
    }
}
