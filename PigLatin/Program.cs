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
            string firstTwoLetters = WordEntered.Substring(0,2);
            string FirstVowel = firstLetter.ToString();
            string FirstTwoCon = firstTwoLetters.ToString();
            if (FirstVowel == "A")
            if (FirstVowel == "E")
            if (FirstVowel == "I")
            if (FirstVowel == "O")
                        {
                            Console.WriteLine($"{WordEntered}way");
                        }
                        else if (FirstTwoCon == "B") ;
                        else if (FirstTwoCon == "C") ;
                        else if (FirstTwoCon == "D") ;
                        else if (FirstTwoCon == "F") ;
                        else if (FirstTwoCon == "G") ;
                        else if (FirstTwoCon == "H") ;
                        else if (FirstTwoCon == "I") ;
                        else if (FirstTwoCon == "J") ;
                        else if (FirstTwoCon == "K") ;
                        else if (FirstTwoCon == "L") ;
                        else if (FirstTwoCon == "M") ;
                        else if (FirstTwoCon == "N") ;
                        else if (FirstTwoCon == "P") ;
                        else if (FirstTwoCon == "Q") ;
                        else if (FirstTwoCon == "R") ;
                        else if (FirstTwoCon == "S") ;
                        else if (FirstTwoCon == "T") ;
                        else if (FirstTwoCon == "V") ;
                        else if (FirstTwoCon == "W") ;
                        else if (FirstTwoCon == "X") ;
                        else if (FirstTwoCon == "Y") ;
                        else if (FirstTwoCon == "Z") ;
            {
                Console.WriteLine($"{WordEntered.Remove(0,2)}{FirstTwoCon}");
            }


        }
    }
}
