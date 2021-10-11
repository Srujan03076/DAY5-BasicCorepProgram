using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_AlphabetVowelorConsonent
{
    class UC_9_CheckTheVowelOrConsonant
    {
        static void Main(string[] args)
        {

            char Alphabet;
            

            Console.WriteLine("Enter the Alphabet");
            Alphabet = char.Parse(Console.ReadLine());

            if ( Alphabet == 'a' || Alphabet == 'e'|| Alphabet == 'i' || Alphabet == 'o' || Alphabet == 'u' )  
            { 
                Console.WriteLine("Alphabet is a vowel");

            }
            else
            {
                Console.WriteLine("Alphabet is a consonant");
            }

            Console.ReadLine();

        }
    }
}