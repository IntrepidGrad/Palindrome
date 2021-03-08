using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class Palindrome
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("Palindrome.cs");

        public Boolean isPalindrome(String inputString)
        {
            String inputStringLower = inputString.ToLower();
            String inputStringLowerNoSpace = inputStringLower.Replace(" ", "");
            StringBuilder sbnormal = new StringBuilder();
            StringBuilder sbrev = new StringBuilder();
            foreach (char character in inputStringLowerNoSpace)
            {
                sbnormal.Append(character);
                sbrev.Insert(0, character);
            }
            if (sbnormal.Equals(sbrev))
            {
                logger.Info("Phrase \"" + inputString + "\" is a palindrome");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
