using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailValidityChecker.Interfaces;

namespace TestForEmailValidity
{
    [TestClass]
    public class EmailisValidTest
    {
       

        [TestMethod]
        public void EmailIsValid()
        {
            //Given a string 
            string expected = "Email is Valid";
            //When ReturnvalidMessage is called
            IEmailisValid _EmailisValid = new EmailisValid();
            string actual = _EmailisValid.ReturnvalidMessage();
            //Then it should return Email is Valid
            Assert.AreEqual(expected, actual);
        }
    }
}
