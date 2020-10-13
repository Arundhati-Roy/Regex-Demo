using Microsoft.AspNetCore.Rewrite.Internal;
using Microsoft.Extensions.FileSystemGlobbing;
using System;
using System.Text.RegularExpressions;

namespace regex_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to regex demo");

            string fname = "";
            getFirstName(fname);
            string lname = "";
            getLastName(lname);
            string email = "";
            getEmail(email);
            string phno = "";
            getPhoneno(phno);
            string pass = "";
            getPass(pass);

        }
        public static bool getFirstName(string fn)
        {
            bool fnval = true;
            // Step 1: the input string.
            while (fnval)
            {
                Console.WriteLine("First Name");
                fn = Console.ReadLine();
                Regex fname = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
                Match fnmatch = fname.Match(fn);
                if (fnmatch.Success)
                {
                    Console.WriteLine("First Name: " + fnmatch.Value);
                    fnval = false;
                }
                else
                    Console.WriteLine("Invalid First Name");
            }
            return true;
        }
        public static bool getLastName(string ln)
        {
            bool lnval = true;
            while (lnval)
            {
                Console.WriteLine("Last Name");
                ln = Console.ReadLine();
                Regex lname = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
                Match lnmatch = lname.Match(ln);
                if (lnmatch.Success)
                {
                    Console.WriteLine("Last Name: " + lnmatch.Value);
                    lnval = false;
                }
                else
                    Console.WriteLine("Invalid Last Name");
            }
            return true;
        }
        public static bool getEmail(string email)
        {
            //bool eval = true;
            Console.WriteLine("Enter your emailId : ");
            string emailid = Console.ReadLine();
            bool eval = EmailIDValidation(email);
            while (!eval)
            {
                Console.WriteLine("Enter a valid emailID : ");
                emailid = Console.ReadLine();
            }
            return true;
        }
        public static Boolean EmailIDValidation(string email)
        {
            Regex regex = new Regex(@"^[a-z][a-zA-Z0-9.+_-]+@[a-zA0-9]+\.(\.?[a-z]{2,}){1,2}$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
                return false;
        }

        public static bool getPhoneno(string phno)
        {
            bool phval = true;
            while (phval)
            {
                Console.WriteLine("Phone no.");
                phno = Console.ReadLine();
                Regex pn = new Regex(@"^\+{0,1}[0-9]{1,3}\s[0-9]{10}$");
                Match pnmatch = pn.Match(phno);
                if (pnmatch.Success)
                {
                    Console.WriteLine("No.: " + pnmatch.Value);
                    phval = false;
                }
                else
                    Console.WriteLine("Invalid Phone no.");
            }
            return true;
        }
        public static bool getPass(string pass)
        {
            bool pval = true;
            while (pval)
            {
                Console.WriteLine("Password");
                pass = Console.ReadLine();
                Regex passc = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");
                Match pmatch = passc.Match(pass);
                if (pmatch.Success)
                {
                    Console.WriteLine("Password: " + pmatch.Value);
                    pval = false;
                }
                else
                    Console.WriteLine("Invalid Passcode");
            }
            return true;
        }

    }
}
