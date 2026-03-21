using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktlt_Lab4
{
    internal class Person
    {
        private string name;
        private int birthYear;
        private string address;


        public int BirthYear
        {
            get => birthYear;
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                { birthYear = value; }
                else
                {
                    Console.WriteLine("value invalid");
                    birthYear = 1900;
                }
            }
        }
        public Person() { }
        public Person(string name, int birthYear, string address)
        {
            this.name = name;
            this.BirthYear = birthYear;
            this.address = address;
        }
        public int GetAge()
        { return DateTime.Now.Year - birthYear; }
        public virtual void Input()
        {
            Console.Write("nhap ten: ");
            name = Console.ReadLine()!;
            Console.Write("nhap nam sinh: ");
            BirthYear = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine()!;
        }
        public override string ToString()
        {
            return $"name:{name}, Nam sinh: {birthYear}, Tuoi : {GetAge()}, Dia chi: {address}";
        }
    }
}
