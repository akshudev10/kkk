
//STRING TYPES 
// 1] STRING MANIPULATION
// i] STRING CONCATENATION
namespace Datatypes
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
}