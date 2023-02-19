namespace FirstClass;

internal class FirstClassAssignment
{
    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        private static void Main(string[] args)
        {
            var total = 3;
            var persons = new Person[total];

            Console.WriteLine("Enter names of three people.");

            for (var i = 0; i < total; i++)
            {
                Console.Write("Enter name of {0} person: ", i);

                persons[i] = new Person
                {
                    Name = Console.ReadLine()
                };
            }

            Console.WriteLine("-------------------------------------------------------");

            for (var i = 0; i < total; i++) Console.WriteLine(persons[i].ToString());

            Console.ReadLine();
        }
    }
}