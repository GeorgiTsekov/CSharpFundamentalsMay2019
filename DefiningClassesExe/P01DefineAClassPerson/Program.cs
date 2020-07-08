using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine($"{person1.Name}: {person1.Age}");

            Person person2 = new Person(20);
            Console.WriteLine($"{person2.Name}: {person2.Age}");

            Person person3 = new Person("Pesho", 30);
            Console.WriteLine($"{person3.Name}: {person3.Age}");
        }
    }
}
