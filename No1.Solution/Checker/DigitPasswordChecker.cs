using System;
using System.Linq;

namespace No1.Solution.Checker
{
    public class DigitPasswordChecker : IPasswordChecker
    {
        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }

            return !password.Any(char.IsNumber) ? (false, $"{password} hasn't digits") : (true, "Password is Ok. User was created");
        }
    }
}