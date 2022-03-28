using System;
using System.Text.RegularExpressions;
namespace Uc1EnterValidFirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RegexProblem");
            Console.WriteLine("Enter Mobile number  to check :");
            string mobileNumber=Console.ReadLine();
            Match(mobileNumber);
        }
        /// <summary>
        /// Matches the specified mobile number.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        public static void Match( string mobileNumber)
        {
            if (Regex.Match(mobileNumber, @"^([0-9]{2})\s([0-9]{10})$").Success)
            {
                Console.WriteLine(" Mobile Number is : " + mobileNumber);
            }
            else
            {
                Console.WriteLine("Failed");
                
            }
        }
    }
}
