using System;
using System.Text.RegularExpressions;
namespace Uc1EnterValidFirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uc1 RegexProblem");
            Console.WriteLine("Enter First name to check :");
            Match("Shubham");
        }
         public  static void Match( string lirstName)
        {
            if (Regex.Match(lirstName, "^[A-Z][a-z]{3,}$").Success)
            {
                Console.WriteLine(" Firt Name is : " + lirstName);
            }
            else
            {
                Console.WriteLine("Failed");
                throw new Exception();
            }
        }
    }
}
