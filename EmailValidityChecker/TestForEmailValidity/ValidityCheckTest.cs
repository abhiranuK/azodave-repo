using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailValidityChecker;
namespace TestForEmailValidity
{
    [TestClass]
    public class TestForLogicMethod
    {
        [TestMethod]
        public void Given_a_ValidString1_Return_True()
        {
            //Given a string abc@123.com
            string input = "abc@123.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }

        [TestMethod]
        public void Given_a_ValidString2_Return_True()
        {
            //Given a string abcde12@123.com
            string input = "abcde12@123.com";

            //When EmailCheckerMethod is called 
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }
        [TestMethod]
        public void Given_a_ValidString3_Return_True()
        {
            //Given abcde1test.email.with+symbol@domain.com
            string input = "abcde1test.email.with+symbol@domain.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }


        [TestMethod]
        public void Given_a_ValidString4_Return_True()
        {
            //Given a string id-with-dash@domain.com
            string input = "id-with-dash@domain.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }

        [TestMethod]
        public void Given_a_ValidString5_Return_True()
        {
            //Given a string a@domain.com
            string input = "a@domain.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }

        [TestMethod]
        public void Given_a_ValidString6_Return_True()
        {
            //Given a string '111abc.testemail'@domain.com
            string input = "111abc.testemail@domain.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }

        [TestMethod]
        public void Given_a_ValidString7_Return_True()
        {
            //Given a string example-abc@abc-domain.com
            string input = "example-abc@abc-domain.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }

        [TestMethod]
        public void Given_a_ValidString8_Return_True()
        {
            //Given a string abcde12@123.com
            string input = "abcde12@123.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }

        [TestMethod]
        public void Given_a_ValidString9_Return_True()
        {
            //Given a string example@localhost
            string input = "example@localhost.com.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }


        [TestMethod]
        public void Given_a_ValidString10_Return_True()
        {
            //Given a string abcde12@123.com
            string input = "abcde1---2@123.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }


        [TestMethod]
        public void Given_a_ValidString11_Return_True()
        {
            //Given a string example@s.solutions
            string input = "example@s.solutions";

            //When EmailCheckerMethod is called 
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }


        [TestMethod]
        public void Given_a_ValidString12_Return_True()
        {
            //Given a string test@com
            string input = "test@1.com1";

            //When EmailCheckerMethod is called 
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return True
            Assert.IsTrue(actual);


        }


        //Tests for Invalid Inputs
        [TestMethod]
        public void Given_an_InValidString1_Return_False()
        {
            //Given a string example.com
            string input = "example.com";

            //When EmailCheckerMethod is called 
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return False
            Assert.IsFalse(actual);


        }


        [TestMethod]
        public void Given_an_InValidString2_Return_False()
        {
            //Given a string A@b@c@domain.com
            string input = "A@b@c@domain.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return False
            Assert.IsFalse(actual);


        }


        [TestMethod]
        public void Given_an_InValidString3_Return_False()
        {
            //Given a string test@domain..com
            string input = "test@domain..com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return False
            Assert.IsFalse(actual);


        }

        [TestMethod]
        public void Given_an_InValidString4_Return_False()
        {
            //Given a string test @domain.com
            string input = "test @domain.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return False
            Assert.IsFalse(actual);


        }

        [TestMethod]
        public void Given_an_InValidString5_Return_False()
        {
            //Given an Invalid input test@_.com
            string input = "test@_.com";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return False
            Assert.IsFalse(actual);


        }

        [TestMethod]
        public void Given_an_InValidString6_Return_False()
        {
            //Given an Invalid input test@.com!
            string input = "test@.com!";

            //When EmailCheckerMethod is called
            IValidityCheck _EmailChecker = new ValidityCheck();
            bool actual = _EmailChecker.EmailCheckerMethod(input);

            //Then it should return False
            Assert.IsFalse(actual);


        }

    }


}

