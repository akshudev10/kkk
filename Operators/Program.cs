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
namespace Datatypes
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
}