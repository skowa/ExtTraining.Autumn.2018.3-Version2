using System;

namespace No1.Solution.Checker
{
    public class LilttleLengthPasswordChecker : IPasswordChecker
    {
        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }

            return password.Length <= 7 ? (false, $"{password} length too short") : (true, "Password is Ok. User was created");
        }
    }
}