using LanguageExt.TypeClasses;
using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {
            //Console.WriteLine("Invalid Entry");
        }
    }
    public class Valid
    {
        public string fname{ get;set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string num { get; set; }
        public string pass{ get; set; }

        /*public Valid()
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.num = num;
            this.pass = pass;
        }
        public static Func<Valid, bool> fnameRule =
        m => (new Regex(@"^[A-Z]{1}[a-z]{2,}$")).IsMatch(m.fname);

        public static Func<Valid, bool> lnameRule =
        m => (new Regex(@"^[A-Z]{1}[a-z]{2,}$")).IsMatch(m.lname);

        public static Func<Valid, bool> emailRule =
        m => (new Regex(@"^[a-z][a-zA-Z0-9.+_-]+@[a-zA0-9]+\.(\.?[a-z]{2,}){1,2}$")).IsMatch(m.email);

        public static Func<Valid, bool> numRule =
            m => (new Regex(@"^\+{0,1}[0-9]{1,3}\s[0-9]{10}$")).IsMatch(m.num);

        public static Func<Valid, bool> passRule =
            m => (new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$")).IsMatch(m.pass);
*/
        public static Func<string, string, bool> validate = (fname, pattern) =>
        {
            Regex re = new Regex(pattern);
            if (re.IsMatch(fname))
                return true;
            else
                return false;
        };

    }


    class LambdaVal
    {
       
        static void Main(string[] args)
        {
            string fname, lname, email, num;
            Valid v = new Valid();
            while (true)
            {
                Console.WriteLine("First Name : ");
                fname = Console.ReadLine();
                try
                {
                    bool valid = Valid.validate(fname, (@"^[A-Z]{1}[a-z]{2,}$"));
                    if (!valid)
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
                    bool valid = Valid.validate(lname, (@"^[A-Z]{1}[a-z]{2,}$"));
                    if (!valid)
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
                    bool valid = Valid.validate(email, (@"^[a-z][a-zA-Z0-9.+_-]+@[a-zA0-9]+\.(\.?[a-z]{2,}){1,2}$"));
                    if (!valid)
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
                    bool valid = Valid.validate(num, (@"^[+][0-9]{2}\\s[7-9]{1}[0-9]{9}$"));
                    if (!valid)
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
                    bool valid = Valid.validate(pass, (@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$"));

                    if (!valid)
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