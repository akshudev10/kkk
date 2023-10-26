// VARIABLES
// TYPES OF DATATYPES--
//1] VALUE TYPE: means directly stores the value in the varaible name
// i) int
//ii) float
//iii) double
//iv) long
//v) bool
//vi) char these are called as value type
//2] REFERENCE TYPE : means uses the indexing method & it helps to refer the value in the variable name 
//i) String
//ii) Array & Alass
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //how to initalize the variable?
            // create an integer
            int a = 10;
            Console.WriteLine(a);
        }
    }
}
//how to add two values 
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
// FLOAT
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            float num1 = 1.2F; //we use the both "f" or "F" after the decimal for the datatype float
            float num2 = 2.3f;
            float num3 = num1 + num2;
            Console.WriteLine(num3);
        }
    }
}*/
//LONG
// We use long datatype for identifying the size of the datatypes
// for int = 4 bytes
//for long = 8 bytes
//for float = 4 bytes
//for double = 8 bytes
// integer datatype only can store 4bytes of the data  but if we use "long" we can store upto 8 bytes of the data
// we are changing "int" to "long" becoz "int" has low storage capacity

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            long a = 12345678;
            long b = 87654321;
            long c = a + b;
            long d = a - b;
            Console.WriteLine(c);
        }
    }
}

// DOUBLE
// whta is the difference  between double & float?
// float only gives the "approximate or limited values" as it has only limited memory storage capacity of 4 bytes.
// double can give larger number values as it has the memory storage capacity of 8 bytes.
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 3.145678; // for double no need to add any letter after the decimal values
            double num2 = 4.567291;
            double num3 = num1 * num2; // dividing
            Console.WriteLine(num3);
        }


    }
}*/
