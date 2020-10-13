using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
//using regex_demo;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using UserRegistrationProblem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*//private readonly regex_demo.Program program;
        public UnitTest1()
        {
            regex_demo.Program program = new regex_demo.Program();
        }*/
        [TestMethod]
        [DataRow("abc123@gmail.com")]
        [DataRow(".12xcv@gmail.com")]
        [DataRow("cgv@gmail")]
        public void TestMethod3(string email)
        {
            bool expected = true;
            //regex_demo.Program program = new regex_demo.Program();
            Valid v = new Valid();
            bool actual = v.EmailIDValidation(email);
            Assert.AreEqual(expected, actual);

        }
    }
}
