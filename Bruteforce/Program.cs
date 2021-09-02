using System;
using System.Linq;
using System.Collections.Generic;
using System.Timers;

//Version 0.1

namespace Bruteforce
{

    class Program
    {
        //number of combination
        public static int combinations = 0;

        //current combination
        public static string combination = "a";

        //password
        public static string password = "a";

        static void Main(string[] args)
        {
            //start menu
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Brute-force-program by Chris");
            Console.WriteLine("Lionforce v.     0.1");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");

                //set password
            Console.WriteLine("Input password with a length of maximal 10 letters/numbers");
            password = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(password);
            
                //start
            Console.WriteLine("Press ENTER to start");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;

            //calling main function
            Cracking();
        }

        public static void Cracking()
        {
            //value to reset sign X int
            int resetval = 1;
            //total number of signs
            int letterarray = 63;
            //length of password
            int passwordlengh = 1;

            //int represent sign
            int letter = 0;
            int letter2 = 0;
            int letter3 = 0;
            int letter4 = 0;
            int letter5 = 0;
            int letter6 = 0;
            int letter7 = 0;
            int letter8 = 0;
            int letter9 = 0;
            int letter10 = 0;
            
            //string array with all signs
            string[] letters =
            {
                    string.Empty, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                    "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
            };

            
            
            while (combination != password)
            {
                combinations++;

                //output of progress
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Current combination N.   " +combinations + ":   " + combination);
                Console.ForegroundColor = ConsoleColor.Green;

                //detection of passwordlengh
                letter++;
                if (letter == letterarray)
                {
                    //increases passwordlengh
                    passwordlengh++;
                    //increases sign number of next sign
                    letter2++;
                    //resets its value
                    letter = resetval;
                }
                if (letter2 == letterarray)
                {
                    passwordlengh++;
                    letter3++;
                    letter2 = resetval;
                }
                if (letter3 == letterarray)
                {
                    passwordlengh++;
                    letter4++;
                    letter3 = resetval;
                }
                if (letter4 == letterarray)
                {
                    passwordlengh++;
                    letter5++;
                    letter4 = resetval;
                }
                if (letter5 == letterarray)
                {
                    passwordlengh++;
                    letter6++;
                    letter5 = resetval;
                }
                if (letter6 == letterarray)
                {
                    passwordlengh++;
                    letter7++;
                    letter6 = resetval;
                }
                if (letter7 == letterarray)
                {
                    passwordlengh++;
                    letter8++;
                    letter7 = resetval;
                }
                if (letter8 == letterarray)
                {
                    passwordlengh++;
                    letter9++;
                    letter8 = resetval;
                }
                if (letter9 == letterarray)
                {
                    passwordlengh++;
                    letter10++;
                    letter9 = resetval;
                }
                if (letter10 == letterarray)
                {
                    //outputs error
                    Console.WriteLine("no combination found");
                    letter3 = resetval;
                }

                //string gets set
                combination = letters[letter] + letters[letter2] + letters[letter3] + letters[letter4] + letters[letter5]
                + letters[letter6] + letters[letter7] + letters[letter8] + letters[letter9] + letters[letter10];




            }

            //results
            if (combination == password)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Correct combination:     " + combination);
                Console.WriteLine("Count of combinations:   " + combinations);
                Console.ForegroundColor = ConsoleColor.Green;
            }

        }
    }
}
