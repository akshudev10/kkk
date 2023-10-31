//Decision Making
// It has 5 methods i)if ii)if else iii)else if iv)nested if v)switch statement
// syntax: if(condition)
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

// ii) IF ELSE CONDITION: in this condition it can check more than one condition or only two conditions
//if else condition ids also called as ternary operator
//syntax: if(condition)
//        {
//          true statement
//        }
//       else
//        {
//          false statement
//        }
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
//iii) ELSE IF: means checking more than one condition
// syntax: if(condition1)
//          {
//            condition 1 true statement
//           }
//          else if(condition2)
//          {
//            condition 2 true statement
//          }
//          else
//          {
//              false statement
//          }
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
//syntax: if(condition1)
//        {
//         if (condition2)
//        {    // execute code when condition1 and condition2 are true. ...

//         else if (condition3)
//        {
//          if (condition4)
//        {     // execute code when condition3 and condition4 are true. ...
//        else
//        {       // execute code when condition3 is true. ...
//        else
//        {      // execute code when conditions1 is false.
/*namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //consoles output will be in string form if we want to change we should use type conversion
            // here type conversion is done from string to int 
            Console.WriteLine("Enter the age");
            string agestring = Console.ReadLine();
            int age = Int32.Parse(agestring);
            Console.WriteLine(age);
        }
    }
}*/
// converting "char or alphabets" into "int" using type conversion method 
// when the output is displayed as"enter the age" & if we enter a "char" as "a" how it can be converted into "int"
// this will help in " not crashing the system"
using System.ComponentModel.Design;
namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the age");
            string agestring = Console.ReadLine();
            int age;
    // syntax for try parse: inside the bracket(input value, out ......)
    // in case the given conversion  got success "out" helps to store the value 
            bool result = int.TryParse(agestring, out age);
           // giving with the condition
             if (age > 10)
            { 
                Console.WriteLine("enter the mall");
                Console.WriteLine("shopping allowed");
            }
            else
            {
                Console.WriteLine(" permission denied");
            }
            
        

        }
    }
}




