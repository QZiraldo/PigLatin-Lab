using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        const string EXTENSION = "ay";


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!\n");

            string run;
            do
            {
                string translation = "";
                string input = Console.ReadLine();
                string[] tempInput = input.Split(' ');

                for (int i = 0; i < tempInput.Length; i++)
                {
                   
                    translation += getPigLatin(Console.WriteLine([i]);
                }

                Console.WriteLine(translation + "/n");

                Console.WriteLine("Translate another line?(y/n)");
                run = Console.ReadLine();
            }
            while (run == "y");
        }

       private string getPigLatin (string input)
        {
            string word;
            string firstLetter = input.Substring(0, 1);

            word = input.Substring(1) + firstLetter + EXTENSION + " ";

            return word;
        }

    }
}
