using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charTestString = testString.ToCharArray();
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char testChar in charTestString)
            {
                if (letterCount.ContainsKey(testChar)) 
                {
                    letterCount[testChar] += 1;
                }
                else 
                { 
                    letterCount.Add(testChar, 1);
                }
            }
            foreach (KeyValuePair<char, int> printKVP in letterCount)
            {
                Console.WriteLine(printKVP.Key + ": " + printKVP.Value);
            }
            // Console.WriteLine(letterCount);
            // Console.WriteLine(testString);
        }
    }
}
