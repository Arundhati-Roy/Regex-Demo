using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {
            Console.WriteLine("Invalid Entries");
        }
    }
    public class Valid
    {
        public Boolean FirstNameValidation(string fname)
        {
            Regex re = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            if (re.IsMatch(fname))
                return true;
            else
                return false;
        }

        public Boolean LastNameValidation(string lname)
        {
            Regex re = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            if (re.IsMatch(lname))
                return true;
            else
                return false;
        }

        public Boolean EmailIDValidation(string email)
        {
            Regex re = new Regex(@"^[a-z][a-zA-Z0-9.+_-]+@[a-zA0-9]+\.(\.?[a-z]{2,}){1,2}$");
            if (re.IsMatch(email))
                return true;
            else
                return false;
        }

        public Boolean MobileNumberValidation(string num)
        {
            Regex re = new Regex(@"^\+{0,1}[0-9]{1,3}\s[0-9]{10}$");
            if (re.IsMatch(num))
                return true;
            else
                return false;
        }

        public Boolean PasswordValidation(string pass)
        {
            Regex re = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");
            if (re.IsMatch(pass))
                return true;
            else
                return false;
        }
        public string MoodAnalyser(string message)
        {
            if (message.Contains("HAPPY"))
                return "HAPPY";
            else
                return "SAD";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Valid v = new Valid();
            string fname, lname, email, num;
            while (true)
            {
                Console.WriteLine("First Name : ");
                fname = Console.ReadLine();
                try
                {
                    if (!v.FirstNameValidation(fname))
                    {
                        throw new CustomException("Invalid first name");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }

            }

            while (true)
            {
                Console.WriteLine("Last Name : ");
                lname = Console.ReadLine();
                try
                {
                    if (!v.LastNameValidation(lname))
                    {
                        throw new CustomException("Invalid last name");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }

            }

            while (true)
            {
                Console.WriteLine("EmailId : ");
                email = Console.ReadLine();
                try
                {
                    if (!v.EmailIDValidation(email))
                    {
                        throw new CustomException("Invalid emailId");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Ph no. : ");
                num = Console.ReadLine();
                try
                {
                    if (!v.MobileNumberValidation(num))
                    {
                        throw new CustomException("Invalid phone number");
                    }
                    break;
                }

                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Password : ");
                string pass = Console.ReadLine();
                try
                {
                    if (!v.PasswordValidation(pass))
                    {
                        throw new CustomException("Invalid password");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }


            Console.WriteLine("Registration Successful!");
            Console.WriteLine("Name :" + fname + " " + lname);
            Console.WriteLine("Email ID : " + email);
            Console.WriteLine("Phone Number : " + num);
        }
    }
}