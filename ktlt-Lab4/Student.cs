using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktlt_Lab4
{
    public class Student : Person
    {
        private string program;
        private int year;

        public Student() : base() { }
        public Student(string name, int birthYear, string address, string program, int year)
            : base(name, birthYear, address)
        {
            this.program = program;
            this.year = year;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter your program: ");
            program = Console.ReadLine()!;
            Console.Write("Enter your year: ");
            year = int.Parse(Console.ReadLine()!);
        }

        public override string ToString()
        {
            return $"Student[{base.ToString()} - Program: {program}, Year: {year}]";
        }

        public void ChangeProgram(string program)
        {
            this.program = program;
        }
    }
}
