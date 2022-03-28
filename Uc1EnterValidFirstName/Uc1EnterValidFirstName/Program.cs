using System;
using System.Text.RegularExpressions;
namespace Uc1EnterValidFirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RegexProblem");
            Console.WriteLine("Enter Email to check :");
            string email=Console.ReadLine();
            Match(email);
        }
         public  static void Match( string email)
        {
            if (Regex.Match(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success)
            {
                Console.WriteLine("Success , Email is : " + email);
            }
            else
            {
                Console.WriteLine("Failed");
                throw new Exception();
            }
        }
    }
}
