
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
namespace Datatypes
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
}       