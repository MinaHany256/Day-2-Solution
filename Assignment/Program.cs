namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            // Single Line Comment

            /*
             * 
             * Multi 
             * Line
             * Comment
             * 
             * */
            #endregion

            #region Declaring Variables
            //int id = 10;

            ////PascalCase -> FirstName
            ////CamelCase  -> firstName 
            ////kababCase  -> first-name  [Angular Files Names]


            //Console.WriteLine(id); 
            #endregion

            #region Value Type
            //int X;
            ////CLR will Allocate 4 unintialized Bytes at the STACK
            ////int : C# Keyword

            //X = 5;
            //Int32 Y = 10;
            ////CLR will Allocate 4 unintialized Bytes at the STACK
            ////Int32 : BCL

            //Y = X;  //5
            //X++;  //6
            //Console.WriteLine(Y); 
            #endregion

            #region Reference Type
            //Point P1;
            ////Declare For Reference of type "Point" refering to NULL
            ////This Reference 'P1' Can Refer To an Object From Type "Point" OR another type "Inherting From Point"
            ////CLR will Allocate 4 bytes for the reference at the STACK
            ////CLR will Allocate 0 bytes At HEAP

            //P1 = new Point();

            //Point P2 = new Point();

            //P2 = P1;
            //P2.x = 6;
            //Console.WriteLine(P1.x);
            #endregion

            #region Object
            //Point P1 = new Point();
            //Point P2 = new Point();

            //Console.WriteLine( P1.ToString() ); //Demo.Point   Namespace of Point + class name of p1

            //Console.WriteLine( P1.GetHashCode() );
            //Console.WriteLine( P2.GetHashCode() );
            //Console.WriteLine(P1.Equals(P2));   //False  

            //object O1;
            //Declare for reference of type "Object" , refering to NULL
            //4 bytes been allocated at STACK for the reference 'O1'
            //0 bytes have been allocated at HEAP

            //O1 = new object();
            //O1 = "Ahmed";
            //O1 = 5;  // Boxing



            #endregion

            #region Fractions and Discards
            //double x = 5.34;
            ////float y = 1.0; //ERROR
            //float y = 1.0f;
            //decimal z = 854.3m;

            ////Discard  (Just for readability)
            //long Number = 100_000_000_000;
            //Console.WriteLine(Number); 
            #endregion

            #region Implicit Casting VS Explicit Casting

            //int x = 10;

            //long y = /*(long)*/ x;  //Implicit Casting  [Safe Casting]

            //long x = 8;

            //checked
            //{
            //    int y = (int)x;   //Explicit Casting 
            //    unchecked
            //    {
            //        Console.WriteLine(y); 
            //    }
            //}



            #endregion

            #region Convert

            //Convert [Class Containing set of methods used for casting from datatype to another]

            //Console.Write("Please Enter Your Name : ");
            //String Name = Console.ReadLine() ?? "NA";

            //Console.Write("Please Enter Your Age : ");
            //int Age  = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please Enter Your salary : ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine($"Your Name is {Name}");
            //Console.WriteLine($"Your Age is {Age}");
            //Console.WriteLine($"Your Salary is {Salary}");

            #endregion

            #region Parse

            //Parse : [is a method used for catsing from string to the caller datatype]


            //Console.Write("Please Enter Your Name : ");
            //String Name = Console.ReadLine() ?? "NA";

            //Console.Write("Please Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Please Enter Your salary : ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();

            //Console.WriteLine($"Your Name is {Name}");
            //Console.WriteLine($"Your Age is {Age}");
            //Console.WriteLine($"Your Salary is {Salary}");


            #endregion

            #region Operators

            #region Unary
            //// Unary 
            //int x = 10;
            ///*Prefix*/ Console.WriteLine(++x); // 11
            ///*Posfix*/ Console.WriteLine(x++); // 10

            ///*Prefix*/
            //Console.WriteLine(--x); // 9
            ///*Posfix*/
            //Console.WriteLine(x--); // 10 
            #endregion

            #region Binary

            //int Sum, Mul, Div, Sub, Mod;
            //int Num01 = 2;
            //int Num02 = 6;

            //Sum = Num01 + Num02;
            //Mul = Num01 * Num02;
            //Div = Num01 / Num02;
            //Sub = Num02 - Num01;
            //Mod = Num02 % Num01;

            #endregion

            #region Assignment

            //int x;
            //x = 4;
            //x += 2;
            //x -= 2;
            //x *= 2;
            //x /= 2;
            //x %= 2;


            #endregion

            #region Relational

            //int x = 6 , y = 5 ;
            //Console.WriteLine(x==y);
            //Console.WriteLine(x!=y);
            //Console.WriteLine(x>y);
            //Console.WriteLine(x>=y);
            //Console.WriteLine(x<=y);
            //Console.WriteLine(x<y);
            //Console.WriteLine(x<=y);

            #endregion

            #region Logical

            //Console.WriteLine(!false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true || false);


            #endregion

            #region Bitwise

            //Console.WriteLine(~0);   // print 1
            //Console.WriteLine(false & true); //Long circuit
            //Console.WriteLine(true | false);

            #endregion

            #region Ternary

            //bool Flag = 4 > 2 ? true : false;
            //Console.WriteLine(Flag);

            #endregion

            #endregion

            #region TryParse

            //String x = "10";
            //int y;
            //int.TryParse(x, out y);
            //Console.WriteLine(y);

            #endregion

        }
    }
}
