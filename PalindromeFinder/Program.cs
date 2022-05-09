using System;


namespace ForFindPalindromes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string x = "";

            Console.WriteLine("Hello, this is my biggest palindrome search app. \n" +
                   "If u want to close the app u may enter \"!stop\"");

            while (x != "!stop")
            {
                Console.Write("Please enter the sentence in which you want to find palindromes:");
                x = Console.ReadLine() ?? "";
                if (x != "!stop")
                { 
                    Console.WriteLine("\nResult: " + FindPalindrome(x) + "\n");
                }
            }
        }

        static string FindPalindrome(string text)
        {
            if (text != "" && text != null)
            {
                int textLength = text.Length;
                string palindrome = text[0..1];
                for (int i = 0; i < textLength; i++)
                {
                    for (int j = i; j <= textLength / 2; j++) 
                    {
                        string textPartLeft = text[i..(textLength - j)];
                        string textPartRight = text[j..(textLength - i)];
                        if (IsPalindrome(textPartRight) && palindrome.Length < textPartRight.Length)
                        {
                            palindrome = textPartRight;
                        }
                        if (IsPalindrome(textPartLeft) && palindrome.Length < textPartLeft.Length)
                        {
                            palindrome = textPartLeft;
                        }
                    }
                }
                return palindrome;
            }
            else
            {
                return "";
            }
        }
        static bool IsPalindrome(string mess)
        {
            for (int i = 0, k = mess.Length - 1; i < mess.Length / 2 && k >= mess.Length / 2; i++, k--)
            {
                if (mess[i] != mess[k])
                {
                    return false;
                }
            }
            return true;
        }
    }   
}
