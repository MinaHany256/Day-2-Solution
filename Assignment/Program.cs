using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-Write a program that allows the user to enter a number then print it.

            //Console.Write("Enter a Number");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine(Number);

            #endregion

            #region 2-Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //String Number1 = "Ahmed";
            //int Number2 = Convert.ToInt32(Number1);
            //Console.WriteLine(Number2);
            //// An Exception will be thrown 

            #endregion

            #region 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float Number1 = 5.75f;
            //float Number2 = 2.5f;

            //float Sum = Number1 + Number2;
            //float Subtract = Number1 - Number2;
            //float Product = Number1 * Number2;
            //float Division = Number1 / Number2;

            //Console.WriteLine("Float Operations:");
            //Console.WriteLine($"Sum: {Sum}");
            //Console.WriteLine($"Subtraction: {Subtract}");
            //Console.WriteLine($"Product: {Product}");
            //Console.WriteLine($"Division: {Division}");

            #endregion

            #region 4-Write C# program that Extract a substring from a given string.

            //string originalString = "Back end Diploma";
            //string substring = originalString.Substring(0, 5);
            //Console.WriteLine(substring);

            #endregion

            #region 5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int Number01;
            //Number01 = 5;
            //int Number02 = 10;
            //Number02 = Number01;   // Number02 = 5
            //Number01++;            // Number01 = 6
            //Console.WriteLine(Number02);  // Print 5 

            #endregion

            #region 6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Point P1;

            //P1 = new Point();

            //Point P2 = new Point();

            //P2 = P1;
            //P2.x = 6;
            //Console.WriteLine(P1.x);

            #endregion

            #region 7-Write C# program that take two string variables and print them as one variable 

            //Console.Write("Enter String 1 : ");
            //String String01 = Console.ReadLine();
            //Console.Write("Enter String 2 : ");
            //String String02 = Console.ReadLine();
            //Console.WriteLine($"{String01} {String02}");

            #endregion

            #region 8-Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.Write("Enter principal amount : ");
            //int PrincipalAmount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter rate of interest : ");
            //int RateOfInterest = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter time : ");
            //decimal time = Convert.ToDecimal(Console.ReadLine());

            //decimal Interest = (PrincipalAmount * RateOfInterest * time) / 100 ;

            //Console.WriteLine($"Interest = {Interest}");

            #endregion

            #region 9-Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI isBMI = (Weight) / (Height * Height)

            //Console.WriteLine("Enter Your Weight in Kilograms");
            //decimal weight = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Enter Height in Meters");
            //decimal height = Convert.ToDecimal(Console.ReadLine());

            //decimal BMI = (weight) / (height * height);

            //Console.WriteLine($"Your BMI is {BMI}");
            #endregion

            #region 10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //double temperature = 25.0;

            //string output = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";

            //Console.WriteLine($"Temprature {temperature} is {output}");

            #endregion

            #region 11-	Write a program that takes the date from user and displays it in various formats using string interpolation.Ex: Today’s date : 20 , 11 , 2001 Today's date : 20 / 11 / 2001 Today's date : 20 – 11 – 2001

            //Console.WriteLine("Enter the day:");
            //int day = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the month:");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the year:");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day} – {month} – {year}");

            #endregion

            #region 12-	 What is the output of the following C# code?  

            //Given Code 
            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //Correct answer 
            //a) The event is on 06/14/2024

            #endregion


        }
    }
}
