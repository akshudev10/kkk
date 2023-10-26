

//CONSOLE METHODS
//1]Console.WriteLine(); means print the output in the new line
//2]Console.Write();   means  print the output in the same line
//3]Console.ReadLine(); means get the input from the user as raw input
//4]Console.Read(); means print the ASCII value according to the given "char"
namespace Datatypes
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
}