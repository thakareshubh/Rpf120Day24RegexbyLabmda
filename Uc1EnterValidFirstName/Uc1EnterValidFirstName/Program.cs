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
         public  static void Match( string firstName)
        {
            if (Regex.Match(firstName, "^[A-Z][a-z]{3,}$").Success)
            {
                Console.WriteLine(" Firt Name is : " + firstName);
            }
            else
            {
                Console.WriteLine("Failed");
                throw new Exception();
            }
        }
    }
}
