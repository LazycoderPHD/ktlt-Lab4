using ktlt_Lab4;

//RunPersonDemo();
void RunPersonDemo()
{
    Person person1 = new Person();
    Person person2 = new Person("Phat", 2007, "125 Sieu sao");
    Person person3 = new Person("SpongeBob", 2000, "123 Oklahoma street");
    //Person person3 = new Person();
    person1.Input();

    Console.WriteLine();

    person2.Input();

    
    Console.WriteLine($"{person1.ToString()}");
    Console.WriteLine($"{person2.ToString()}");
    Console.WriteLine($"{person3.ToString()}");
}

//RunStudentDemo();
void RunStudentDemo()
{
    Student s = new Student();
    s.Input();
    Console.WriteLine(s.ToString());
}

RunStaffDemo();
void RunStaffDemo()
{
    Staff st = new Staff("Dao Nguyen Phat", 2007, "125 sieu sao", "IT", 1500.5);
    Console.WriteLine(st.ToString());
    st.UpdateSalary(2000.5);

    Console.WriteLine();
    Console.WriteLine("Salary after update: " + st.ToString());
}