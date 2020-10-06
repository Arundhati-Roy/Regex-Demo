using Microsoft.AspNetCore.Rewrite.Internal;
using Microsoft.Extensions.FileSystemGlobbing;
using System;
using System.Text.RegularExpressions;

namespace regex_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to regex demo");

            // Step 1: the input string.
            Console.WriteLine("First Name");
            string pin = Console.ReadLine();
            Regex fname = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            Match fnmatch = fname.Match(pin);
            if (fnmatch.Success)
                Console.WriteLine("First Name: " + fnmatch.Value);
            else
                Console.WriteLine("Invalid First Name");

            Console.WriteLine("Last Name");
            string ln = Console.ReadLine();
            Regex lname = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            Match lnmatch = lname.Match(ln);           
            if (lnmatch.Success)
                Console.WriteLine("Last Name: " + lnmatch.Value);
            else
                Console.WriteLine("Invalid Last Name");

            Console.WriteLine("Email");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^[a-z][a-zA-Z0-9.+_-]+@[a-zA0-9]+\.(\.?[a-z]{2,}){1,2}$");
            Match match = regex.Match(email);
            if (match.Success)
                Console.WriteLine("Email: " + match.Value);
            else
                Console.WriteLine("Invalid Email");

            Console.WriteLine("Phone no.");
            string phno = Console.ReadLine();
            Regex pn = new Regex(@"^[0-9]{1,3}\s[0-9]{10}$");
            Match pnmatch = regex.Match(phno);
            if (pnmatch.Success)
                Console.WriteLine("No.: " + match.Value);
            else
                Console.WriteLine("Invalid Phone no.");

            Console.WriteLine("Password");
            string pass = Console.ReadLine();
            Regex passc = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");
            Match pmatch = regex.Match(pass);
            if (pmatch.Success)
                Console.WriteLine("Password: " + match.Value);
            else
                Console.WriteLine("Invalid Passcode");
        }
    }
}