using System;
using System.Text.RegularExpressions;
namespace Uc1EnterValidFirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration");
            string firstName, lastName, email, mobileNumber, password;

            Console.WriteLine(" Enter First Name");
            firstName = Console.ReadLine();
            
            Console.WriteLine(" Enter Last Name");
            lastName = Console.ReadLine();
            
            Console.WriteLine(" Enter Email");
            email = Console.ReadLine();
            
            Console.WriteLine(" Enter Mobile Number ");
            mobileNumber = Console.ReadLine();
            
            Console.WriteLine(" Enter Password");
            password = Console.ReadLine();

            Check( firstName, lastName,  email, mobileNumber, password);

            string mood = Console.ReadLine();
            MoodAnalyser moodCheck = new MoodAnalyser(mood);

            moodCheck.AnalyserMood();

        }

        /// <summary>
        /// Checks the specified fname.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="mail">The mail.</param>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public static bool Check(string fname,string lname,string mail,string mobileNumber,string password)
        {

            var result1 = Regex.Match(lname, "^[A-Z][a-z]{3,}$").Success;
            var result2 = Regex.Match(fname, "^[A-Z][a-z]{3,}$").Success;
            var result3 = Regex.Match(mail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success;
            var result4= Regex.Match(mobileNumber, @"^([0-9]{2})\s([0-9]{10})$").Success;
            var result5 = Regex.Match(password, @"^([A-Za-z]{5,})([`~!@#$%^&*()_+=:;.,'<>/|\?]{1})([0-9]{1,})$").Success;

            if (result1 && result2 && result3 && result4 && result5)
            {

                Console.WriteLine("Success");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;

            }





        }


    }
}
