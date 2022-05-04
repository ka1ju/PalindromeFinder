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
                char[] ArrayString = text.ToCharArray();

                char[] Palindrome = { ArrayString[0] };

                char[] part;

                for (int j = ArrayString.Length, k = 0; j > 0; j -= 2, k++)
                {
                    for (int i = k + 1; i <= j; i++)
                    {
                        part = ArrayString[k..i];
                        char[] p = new char[part.Length];
                        Array.Copy(part, p, part.Length);
                        Array.Reverse(p, 0, p.Length);
                        string pp = String.Join("", p);
                        string ppart = String.Join("", part);
                        if (pp == ppart && part.Length >= Palindrome.Length)
                        {
                            Palindrome = part;
                        }
                    }
                    for (int i = j - 1; i > 0; i--)
                    {
                        part = ArrayString[i..j];
                        char[] p = new char[part.Length];
                        Array.Copy(part, p, part.Length);
                        Array.Reverse(p, 0, p.Length);
                        string pp = String.Join("", p);
                        string ppart = String.Join("", part);
                        if (pp == ppart && part.Length >= Palindrome.Length)
                        {
                            Palindrome = part;
                        }
                    }
                }
                return String.Join("", Palindrome);
            }
            else
            {
                return String.Empty;
            }
        }
    }   
}
;