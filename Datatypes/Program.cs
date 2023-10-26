using System.Globalization;
//VARIABLES
// TYPES OF DATATYPES
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
}*/
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
}*/
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

/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            long a = 12345678;
            long b = 87654321;
            long c = a + b;
            Console.WriteLine(c);
        }
    }
}*/
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
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
//in this case we are getting the input from the user 
            Console.WriteLine("Enter a Two Numbers");
            string a = Console.ReadLine();
            string b = Console.ReadLine()
// to add two numbers we have to change the intput from string to integer
// to change a string to int use the keyword of Int32.Parse()
            int num1 = Int32.Parse(a); 
            int num2 = Int32.Parse(b);
            int c = num1 + num2;

            Console.WriteLine(c);
        }
    }
}*/
//STRING & ITS METHODS 
// 1] STRING MANIPULATION
// i] STRING CONCATENATION
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Achu";
            int age = 10;
            string Address = "Kerala";
            // to dispaly more than one string in the output here string concatenation string operation  is used 
            // "+" symbol is used to concatenate the string elements
            // we have used double quotes inbetween a space as " " for space between  each words 
            Console.WriteLine("Hi am" + " " + Name + " " + "my age is" + " " + age + " " + "from" + " " + Address);
 //ii]STRING FORMATTING : means mentioning the index values inside the printing line using {0} {1} {2}
            // indexing always starts with (o)
            Console.WriteLine("Hi am {0} my age is {1} from {2}", Name,age,Address);
 // iii] STRING INTERPOLATION: means we use a "$" doller sign without spacing  & mention without indexing values  inside the curly braces
            Console.WriteLine($"Hi am {Name} my age is {age} from {Address}");
//iv] STRING VERBATIM
            // we use \n to print the line in a new line or next line
            Console.WriteLine($"Hi am {Name}\n my age is {age} from {Address}");
             //  if we use Verbatim "@" in the starting of  the line
            // if "\n" is already used it will not be printed 
           // here in this case the \n is considered as a string
            Console.WriteLine(@"Hi am {Name}\n my age is {age} from {Address}");
  }

    }
}*/
// STRING METHODS 
/*namespace Datatyypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            //while declaring variable name here it is "firstName" the first letter of the word should be in "small letter"
            // & the second letter of the first word should be "capital letter"
            string firstName = "Akshara";
            string lastName = "Dev";
// i] UPPERCASE: use the keyword [.ToUpper()]
//ii] LOWERCASE: use the keyword [.ToLower()]
            Console.WriteLine(firstName.ToUpper() + " " + lastName.ToLower());
}
    }
*/
// iii] TRIM: means removing unwanted space
// keyword: [.Trim()]
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            string firstName = "Akshara";
            string lastName = "Dev";
            string fullName = string.Concat(" " + firstName, lastName +" ");
            Console.WriteLine(fullName.Trim());
        }
    }
}*/
//iv] SUBSTRING: substring work on the basis of index position of the value in the  variable name 
// substring is also called as "function to print"
// keyword [.Substring()]
/*namespace Datatypes
{ class Program
    {
        static void Main(string[] args) 
        {
            string firstName = "Achu";
            string lastName = "Dev";
            Console.WriteLine(firstName.Substring(2));
            Console.WriteLine(lastName.Substring(1));
        }
    }
}*/
// STRING OPERATIONS
//i] INDEXOF : means to identify which position is the input value
//keyword : .IndexOf( give any random position of the input value inside the single quote)
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            string name = "Akshu";
            Console.WriteLine(name.IndexOf('h')); 
        }
    }
}*/
//ii] ISNULL OR WHITESPACE-NULL OR BLANK
//isNullOrWhiteSpace() is a string method.
//It is used to check whether the specified string is null or contains only white-space characters.
//A string will be null if it has not been assigned a value or has explicitly been assigned a value of null.
// keyword = string.IsNullOrWhiteSpace()
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;
/*namespace Datatypes
{
class Program
{
static void Main(string[] args) 
{
string firstName = "Achu";
string lastName = "Dev";
string fullname = string.Concat(" " + firstName, lastName);
bool b1 = String.IsNullOrWhiteSpace(fullname);
Console.WriteLine(b1);
}
}
}*/
//CONSOLE METHODS
//1]Console.WriteLine(); means print the output in the new line
//2]Console.Write();   means  print the output in the same line
//3]Console.ReadLine(); means get the input from the user as raw input
//4]Console.Read(); means print the ASCII value according to the given "char"
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
        int data = Console.Read();
            Console.WriteLine(data);
 //5]Console.Readkey(); means to read the output in the internet explorer or in any of the default browsers 
// set an option to read the file                                    
// readkey() helps to pause or stop 
            Console.ReadKey();
        }
    }
}*/

//METHODS/FUNCTIONS
// A method is a block of code which only runs when it is called.
//pass the data,known as parameters
// it is used to perform certain actions  and are also known as functions
// NOTE:why use methods? 
// i) to reuse code.
// ii) define the code once & use it many times
// what is access specifier? 
// access specifier refers to whether the method has to be in public or private or protected 
// Return Type: in what type the data is returned like int,float,bool,etc if we call the function in what type the data is returned
// if we write a code for a program once we can use it many times in different programs as necessary
//SYNTAX: <Access specifier> <Return Type> <Method Name>(Parameter List)
//         {
//          Method Body
//          }
// In Return Type there are two types 
//   i) Non-ReturnType
//   ii) ReturnType
/*namespace Datatypes // Non-ReturnType
{
    class Program
    {
        static void Main(string[] args) 
        {
            Printer();
        }
        public static void Printer()
        {
            Console.WriteLine("hi am Achu");
            Console.ReadKey();
        }
        
    }
}*/
// ReturnType
/*namespace Datatypes // Non-ReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Cal());
        }
        public static int Cal()
        {
            int a = 10;
            int b = 10;
            int c = a + b;
            return c;
        }
    }
}*/
// Parameterized Function :means inside a function passing the parameters and processing the data
// function can be reused again  again
// many parameters can passed 
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cal(3,6,9));// passing the parameters
            Console.WriteLine(Cal(3,6,9));// passing multiple  parameters
            Console.WriteLine(Cal(3,6,9));
        }
        public static int Cal( int a, int b, int d)
        {
            int c = a + b +d;
            return c;
        }
    }
}*/
// code reusability
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal("Anie");
            Cal("John");
        }
        public static void Cal(string name)
        {
            Console.WriteLine($"Hi, My Name is {name}");
        }
    }
}*/
//OPERATORS 
//Assignment operator "="
//Arithmetic operators "+ - * / %
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation(5 , 3);
        }
        public static void Calculation(int a, int b)
        {
            // var is used to  automatically determine the datatype of the result here
            var result = a + b;
            Console.WriteLine($"Addition : {result}");
            result = a - b;
            Console.WriteLine($"Subtraction: {result}");
            result = a * b;
            Console.WriteLine($"Multiplication : {result}");
            result = a / b;
            Console.WriteLine($"Division : {result}");
            result = a % b;
            Console.WriteLine($"Modulus : {result}");
        }
    }
}*/
//RELATIONAL OPERATOR: "==, <,>,<=,>="
//Relational operators always returns the boolean value (ie) whether the condition is true or false
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            bool result = a != b;
            Console.WriteLine(result);
        }
    }
}*/
//LOGICAL OPEARTORS: &&(AND), ||(OR)
// This operatorr is used to check more than one condiion
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            // here the && (and) operator check both the condition & whether both the conditions are true it will provie the result  as true 
            // In the && operator both conditions must be true or both the condition should be false
            // In the || operator if one condition is true & the other condition is false  the result will be true 
            // In the || operator if both the condition ids false the condition will be false
            bool result = (a != b) || (a>b); 
            Console.WriteLine(result);
        }
    }
}*/
//UNARY OPERATORS: +,-,++,--,!
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            // here the arithmetic operators are multiplied with the value
            Console.WriteLine(+a);
            Console.WriteLine(-a);
            // here this symbol "++" is the increment operator
            // here the "++" is after the value so it is called post increment operator
            Console.WriteLine(a++);
            // in this case the value will be printed in the next line
            Console.WriteLine(a);
            // here the "++" is before the value so it is called pre increment operator
            // in this case the line will be printed & executed in the same line
            Console.WriteLine(++a);
            // here this symbol"--" is before the value so it is called the predecrement operator
            Console.WriteLine(--a);
            // here this symbol"--" is after  the value so it is called the postdecrement operator
            Console.WriteLine(a--);
            //in this case the value will be printed in the next line
            Console.WriteLine(a);
        }
    }
}*/
// LOGICAL NEGATION [!=]
// means if we use the exclamatory mark before the print line the opposite result will get printed
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            Console.WriteLine(!result);
        }
    }
}*/
//TERNARY OPERATOR
//syntax: condition? true : false
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 54;
            int b = 60;
            string result = a < b ? "A less than B" : "B less than A";
            Console.WriteLine(result);
        }
    }
}*/





































