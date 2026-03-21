using ktlt_Lab4;

RunPersonDemo();
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

