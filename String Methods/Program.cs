
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
namespace Datatypes
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
}