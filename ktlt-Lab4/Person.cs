using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktlt_Lab4
{
    public class Person
    {
        protected string name;
        protected int birthYear;
        protected string address;

        public Person() { }
        public Person(string name, int birthYear, string address)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.address = address;
        }

        public virtual void Input()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine()!;
            Console.Write("Nhap nam sinh: ");
            birthYear = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine()!;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - birthYear;
        }

        public override string ToString()
        {
            return $"Person[Name: {name}, Age: {GetAge()}, Address: {address}]";
        }
    }
}
