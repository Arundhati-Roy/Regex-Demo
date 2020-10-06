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
            Console.WriteLine("Name");
            string pin = Console.ReadLine();
            //Regex regex = new Regex(@"^[^@\s.+_-]+@[^@\s]+\.+[^@\s]+$");
            //Regex regex = new Regex(@"^[a-z][a-zA-Z0-9.+_-][a-zA-Z0-9]+@[a-z0-9]+\.{1,2}+[a-z]{2,}+$");
            //Regex regex = new Regex(@"^([a-z][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]([a-z0-9-]*[a-z0-9])?)$");
            // Step 2: call Match on Regex instance.

            Regex name = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
            Match match = name.Match(pin);

            // Step 3: test for Success.
            if (match.Success)
            {
                Console.WriteLine("Name: " + match.Value);
            }
            else
            {
                Console.WriteLine("Invalid NameS");
            }
        }
    }
}
