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
            Console.WriteLine("Pin code");
            string pin = Console.ReadLine();
            Regex regex = new Regex(@"^[1-9]{1}[0-9]{5}$");
            
            // Step 2: call Match on Regex instance.
            Match match = regex.Match(pin);

            // Step 3: test for Success.
            if (match.Success)
            {
                Console.WriteLine("Pin code: " + match.Value);
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
        }
    }
}
