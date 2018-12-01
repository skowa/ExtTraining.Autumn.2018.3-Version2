using System;

namespace No1.Solution.Checker
{
    public class EmptyPasswordChecker : IPasswordChecker
    {
        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }

            return password == string.Empty ? (false, $"{password} is empty ") : (true, "Password is Ok. User was created");
        }
    }
}