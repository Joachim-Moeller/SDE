Console.WriteLine("Type 2 integers and get their multiplication if both are divisible by 2 or 3, otherwise their sum.");

Console.Write("Type the 1st integer: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Type the 2nd integer: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("The result is: ");

if (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0)
{
    Console.WriteLine(a * b);
}
else
{

    Console.Write(a + b);
    Console.ReadLine();
}