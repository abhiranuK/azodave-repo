using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailValidityChecker.Interfaces;

namespace TestForEmailValidity
{
    [TestClass]
    public class TestFor_InCorrectOutputToUser
    {
        [TestMethod]
        public void EmailIsNotValid()
        {
            //Given an string 
            string expected = "Email is InValid";
            IEmailisNotValid _EmailisNotValid = new EmailisNotValid();
            //When ReturnInvalidMessage is called
            string actual = _EmailisNotValid.ReturnInvalidMessage();
            //Then it should return Email is InValid
            Assert.AreEqual(expected, actual);
        }
    }
}
