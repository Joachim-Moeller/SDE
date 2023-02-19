namespace Constructors;

internal class ConstructorsAssignment
{
    public static void Main(string[] args)
    {
        var total = 3;
        var persons = new Person[total];

        Console.WriteLine("Enter names of three people.");

        for (var i = 0; i < total; i++)
        {
            Console.Write("Enter name of {0} person: ", i);
            persons[i] = new Person(Console.ReadLine());
        }

        Console.WriteLine("-------------------------------------------------------");

        for (var i = 0; i < total; i++) Console.WriteLine(persons[i].ToString());
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        Person()
        {
            Name = string.Empty;
        }
    }
}