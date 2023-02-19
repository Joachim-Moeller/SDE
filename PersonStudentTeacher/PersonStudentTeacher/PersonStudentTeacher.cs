namespace PersonStudentTeacher;

public class Person
{
    protected int age;

    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int n)
    {
        age = n;
    }
}

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is {0} years old", age);
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}

public class PersonStudentTeacher
{
    public static void Main()
    {
        var myPerson = new Person();
        myPerson.Greet();

        var myStudent = new Student();
        Console.Write("Input age of student: ");
        myStudent.SetAge(Convert.ToInt32(Console.ReadLine()));
        myStudent.Greet();
        myStudent.ShowAge();
        myStudent.Study();

        var myTeacher = new Teacher();
        Console.Write("Input age of teacher: ");
        myTeacher.SetAge(Convert.ToInt32(Console.ReadLine()));
        myTeacher.Greet();
        myTeacher.Explain();
    }
}