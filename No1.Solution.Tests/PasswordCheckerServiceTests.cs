using System.Collections.Generic;
using No1.Solution.Checker;
using No1.Solution.Repository;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void AddTest()
        {
            IPasswordChecker[] checkers = {new LetterPasswordChecker(), new BigLengthPasswordChecker(), new DigitPasswordChecker(), new EmptyPasswordChecker()};
            PasswordCheckerService service = new PasswordCheckerService(new CompositePasswordChecker(checkers), new SqlRepository());

            Assert.AreEqual(service.Add("a12345678").Item2, "Password is Ok. User was created");
        }

        [Test]
        public void AddTest_PasswordIsNotAdded()
        {
            IPasswordChecker[] checkers = { new LetterPasswordChecker(), new LilttleLengthPasswordChecker(), new DigitPasswordChecker(), new EmptyPasswordChecker() };

            PasswordCheckerService service = new PasswordCheckerService(new CompositePasswordChecker(checkers), new SqlRepository());

            Assert.AreEqual(service.Add("a125678").Item2, "a125678 length too short");
        }

        [Test]
        public void AddTest_OtherChecker()
        {
            PasswordCheckerService service = new PasswordCheckerService(new Checker(), new SqlRepository());

            Assert.AreEqual(service.Add("a12345678").Item2, "Password is Ok. User was created");
        }

        [Test]
        public void AddTest_OtherChecker_IsMotAdded()
        {
            PasswordCheckerService service = new PasswordCheckerService(new Checker(), new SqlRepository());

            Assert.AreEqual(service.Add("12345678").Item2, "12345678 does not contain a");
        }

        private class Checker : IPasswordChecker
        {
            public (bool, string) VerifyPassword(string password)
            {
                if (password.IndexOf('a') == -1)
                {
                    return (false, $"{password} does not contain a");
                }

                return (true, "Password is Ok. User was created");
            }
        }
    }
}