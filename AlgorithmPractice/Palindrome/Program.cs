using System;

namespace Palindrome
{
    /*
     * What is a PALINDROME?
     * A palindromic number is a number/word (such as 16461 or dad)
     * that remains the same when its digits/character are reversed.
     * In other words, it has reflectional symmetry across a vertical axis
     */
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "DAD";
            Console.WriteLine(Palindrome(palindrome));
            Console.ReadKey();
        }

        static bool Palindrome(string palindromeNumber)
        {
            #region I know this process over-engineered and tiring. you can optimize it at your end or when practicing.
            var convertToArray = palindromeNumber.ToCharArray();
            Array.Reverse(convertToArray);
            var reverted = String.Join("", convertToArray);
            #endregion
            if (palindromeNumber == reverted)
            {
                return true;
            }
            return false;
        }
    }

    
}
