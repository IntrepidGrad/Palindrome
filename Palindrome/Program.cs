using System;
using System.Text;
using log4net.Config;
using Palindrome;

namespace Palindrome
{
    class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("Program.cs");
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            Palindrome program = new Palindrome();
            String inputString = "do geese see god";
            String inputString2 = "go hang a salami im a lasagna hog";
            Boolean isPalindrome1 = program.isPalindrome(inputString);
            Boolean isPalindrome2 = program.isPalindrome(inputString2);
            Boolean isPalindrome3 = program.isPalindrome("sjhfj");

            Console.WriteLine(isPalindrome1);
            Console.WriteLine(isPalindrome2);
            Console.WriteLine(isPalindrome3);

        }

        
    }
}
