using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the function Disemvoweler and send the following parameters
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninija, baby. I make the functions and I make the calls.");


            Console.ReadKey();
        }

        //create a function Disemvoweler that takes the vowels out and rewrites 
        //the string the with just the consonants.
        static void Disemvoweler(string input)
        {
            //declare string variables to store the vowels and consonants as they are 
            //separated.
            string disemvoweled = "";
            string outVowel = "";
            string discardChar = ""; 

            //print the original input string to the console
            Console.WriteLine(input);

            //loop through the entrie string input and determine if they are vowels
            //or consonants, specail chars and store them separately into the three different variables. 
            for (int i = 0; i < input.Length; i++)
            {
                //take each char as it is looped, and covert it to a string and store it in the
                //variable letter
                string letter = input[i].ToString();

                //using an if/else if statment check each incoming character to see if a vowel
                //consonant, or special char and store them into the proper variables 
                //check if letter is contained in within the values of vowels
                if ("aeiou".Contains(letter.ToLower()))
                {
                    //if a vowel, store into outVowel
                    outVowel = outVowel + letter.ToLower();

                }

                    //else if one of these chars store into discardChar
                else if("!.,?' '".Contains(letter))
                {
                    //if chara store into discardChar
                    discardChar = discardChar + letter;

                }
                    //else store into disemvoweled
                else
                {
                    //if other than vowel or char, store into disemvoweled
                    disemvoweled = disemvoweled + letter.ToLower();
                }
            }

            //print into console all the consonants and the vowels
            Console.WriteLine(disemvoweled);
            Console.WriteLine(outVowel);
        }
    }
}
