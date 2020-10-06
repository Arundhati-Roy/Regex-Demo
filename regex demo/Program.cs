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
            //Regex regex = new Regex(@"^[^@\s.+_-]+@[^@\s]+\.+[^@\s]+$");
            //Regex regex = new Regex(@"^[a-z][a-zA-Z0-9.+_-][a-zA-Z0-9]+@[a-z0-9]+\.{1,2}+[a-z]{2,}+$");
            //Regex regex = new Regex(@"^([a-z][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]([a-z0-9-]*[a-z0-9])?)$");
            // Step 2: call Match on Regex instance.

            Regex fname = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            Match fnmatch = fname.Match(pin);

            Console.WriteLine("Last Name");
            string ln = Console.ReadLine();
            Regex lname = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            Match lnmatch = lname.Match(ln);

            // Step 3: test for Success.
            if (fnmatch.Success)
            {
                Console.WriteLine("First Name: " + fnmatch.Value);
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
            if (lnmatch.Success)
            {
                Console.WriteLine("Last Name: " + lnmatch.Value);
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
