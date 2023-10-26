//EXPLICIT CONVERSION :means converting larger datatypes into smaller datatypes
//How to convert float to int
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 3.14f;
            int a = (int)num1;
            Console.WriteLine(a);
            // while converting float to int the decimal values are not printed in the output only thr integer values is printed
        }
    }
}*/
// IMPLICIT CONVERSION:means converting smaller dattypes to larger datatypes
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            long num1 = a;
            // int has only 32 bit storage so it will display as Int32
            // long has 64 bit storage so it will display as Int64
            // we are using "GetType()" for finding the datatype 
            Console.WriteLine(num1.GetType());
            Console.WriteLine(a.GetType());

        }
    }
}*/
//TYPE CONVERSION : means changing  the value of the datatype
// Converting "int, float, double " to "string" 
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a = 50; // float,double
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            // we cannot directly convert int to string so we use a keyword .ToString()
            string value = a.ToString();
            Console.WriteLine(value);
            Console.WriteLine(value.GetType());

           
        }
    }
}*/
// HOW TO GET INPUT FROM THE USER
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
//in this case we are getting the input from the user 
            Console.WriteLine("Enter a Two Numbers");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
// to add two numbers we have to change the intput from string to integer
// to change a string to int use the keyword of Int32.Parse()
            int num1 = Int32.Parse(a); 
            int num2 = Int32.Parse(b);
            int c = num1 + num2;

            Console.WriteLine(c);
        }
    }
}