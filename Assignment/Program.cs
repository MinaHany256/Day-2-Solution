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

        }
    }
}
