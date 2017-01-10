using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string Translation = "This is the Pig Lating Translation";
            string EnterWord = "Enter word here";


            Console.WriteLine(EnterWord);
            string WordEntered = Console.ReadLine();
            Console.WriteLine(Translation);
            char firstLetter = WordEntered[0];
            char SecondLetter = WordEntered[1];
            string Firstletter = firstLetter.ToString();
            string firstTwoletters = WordEntered.Substring(0, 2);
            string FirstVowel = firstLetter.ToString();
            char[] Conletters = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            string Cons = new string(Conletters);
            char[] Vletters = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            string vowels = new string(Vletters);
            if (vowels.Contains(firstLetter))
            {
                Console.WriteLine($"{WordEntered}way");
            }
            else if (Cons.Contains(Firstletter) && Cons.Contains(SecondLetter))
            {
                string RemoveFirstTwo = WordEntered.Remove(0, 2);
                Console.WriteLine($"{RemoveFirstTwo}{firstTwoletters}ay");
            }
            else if (Cons.Contains(Firstletter) && vowels.Contains(SecondLetter))
            {
                string RemoveFirstOne = WordEntered.Remove(0, 1);
                Console.WriteLine($"{RemoveFirstOne}{Firstletter}ay");
                Console.WriteLine();
            }

        }

    }
}







