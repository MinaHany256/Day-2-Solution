namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name : ");
            String Name = Console.ReadLine() ?? "NA";

            Console.Write("Please Enter Your Age : ");
            int.TryParse(Console.ReadLine(), out int Age);

            Console.Write("Please Enter Your Salary : ");
            int.TryParse(Console.ReadLine(), out int Salary);

            Console.Clear();

            Console.WriteLine($"Your Name is { Name }");
            Console.WriteLine($"Your Age is { Age }");
            Console.WriteLine($"Your Salary is { Salary }");

        }
    }
}
