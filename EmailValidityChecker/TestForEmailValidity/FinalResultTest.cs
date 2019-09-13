using System;
using EmailValidityChecker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestForEmailValidity
{
    [TestClass]
    public class FinalResultTest
    {
        [TestMethod]
        public void Given_a_string_get_Email_is_Valid()
        {
            //Given a string abc@123.com
            string input = "abc@123.com";
            string expected = "Email is Valid";
           
            IFinalResult _Result = new FinalResult();

            //When ReturnFinalResult is called
            string actual = _Result.ReturnFinalResult(input);

            //Then it should return Email is Valid
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given_a_string_get_Email_is_InValid()
        {
            //Given a valid string abc@123.com!
            string input = "abc@123.com!";
            string expected = "Email is InValid";

            IFinalResult _Result = new FinalResult();

            //When ReturnFinalResult is called
            string actual = _Result.ReturnFinalResult(input);

            //Then it should return Email is InValid
            Assert.AreEqual(expected, actual);
        }
    }
}
