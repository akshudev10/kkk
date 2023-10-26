

//METHODS OR FUNCTIONS
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
// Non-ReturnType
/*namespace Datatypes 
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
namespace Datatypes
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
}
