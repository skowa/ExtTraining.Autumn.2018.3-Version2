using System.Collections.Generic;

namespace No1.Solution.Checker
{
    /// <summary>
    /// The class that checks password for validity.
    /// </summary>
    public class CompositePasswordChecker : IPasswordChecker
    {
        private readonly IEnumerable<IPasswordChecker> _checkers;

        public CompositePasswordChecker(IEnumerable<IPasswordChecker> checkers)
        {
            _checkers = checkers;
        }

        /// <summary>
        /// The method that checks the <paramref name="password"/> for validity.
        /// </summary>
        /// <param name="password">
        /// The password to be checked.
        /// </param>
        /// <returns>
        /// The tuple, whether password is okey and description string about it.
        /// </returns>
        public (bool, string) VerifyPassword(string password)
        {
            foreach (IPasswordChecker checker in _checkers)
            {
                var result = checker.VerifyPassword(password);
                if (!result.Item1)
                {
                    return result;
                }
            }

            return (true, "Password is Ok. User was created");
        }
    }
}