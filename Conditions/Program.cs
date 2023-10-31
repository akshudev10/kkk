//Decision Making
// It has 5 methods i)if ii)if else iii)else if iv)nested if v)switch statement
// syntax: if()
//          {
//             statement
//           }
// IF CONDITION
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a = 10;
            int b = 20;
            if (a < b)
            {
                Console.WriteLine("A is less than B");
                //in "if" condition it checks only one condition it cant check more than that condition
            }
        }
    }
}*/

// IF ELSE CONDITION: in this condition it can check more than one condition or only two conditions
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            if (a < b)
            {
                Console.WriteLine("A is greater than B");
            }
            else
            {
                Console.WriteLine("B is greater than A");
            }
        }
    }
}*/
// we can use logical operators[&&,||] to check more than one condition  in "if" condition
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            if ((a > b) && (b < a))
            // && operator satisfies the condition when both the conditions are true the output will be true
            // here it goes to the else condition to display the output 
            {
                Console.WriteLine("A is less than B");
            }
            else
            {
                Console.WriteLine("A is greater than B ");
            }
        }
    }
}*/
//iii) ELSE IF:
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;
            if (a < b)

            {
                Console.WriteLine("A is less than B");
            }
    //  here after else a "if" condition is applied
            else if (a == b)
            {
                Console.WriteLine("A equal B ");
            }
            else
            {
                Console.WriteLine(" A is greater than B");

            }
        }
    }
}*/
// NESTED IF:
namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //consoles output will be in string form if we want to change we should use type conversion
            // here type conversion is done from string to int 
            Console.WriteLine("Enter the age");
            // If we give a "variable" in the output it cannot convert the variable to int
            // How to avoid such kind of conditions?
            string agestring =Console.ReadLine();
            int age = Int32.Parse(agestring);
            Console.WriteLine(age);
        }
    }
}




