using System;
using System.Text.RegularExpressions;
namespace Uc1EnterValidFirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RegexProblem");
            Console.WriteLine("Enter Password  to check :");
            string password=Console.ReadLine();
            Match(password);
        }
        /// <summary>
        /// Matches the specified password.
        /// </summary>
        /// <param name="password">The password.</param>
        public static void Match( string password)
        {
            if (Regex.Match(password, @"^([A-za-z]{5,})([@~!`#$%^&*]{1})([0-9]{1,})$").Success)
            {
                Console.WriteLine("Success , Password is : " + password);
            }
            else
            {
                Console.WriteLine("Failed");
                
            }
        }
    }
}
