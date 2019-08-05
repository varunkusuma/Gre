using System;
using System.Collections.Generic;

namespace GreWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Words wordSource = new Words();
            List<string> words = wordSource.GetWordList();

            Random rand = new Random();

            Console.ReadLine();
            while (words.Count > 0)
            {
                int index = rand.Next(words.Count+1);
                string word = words[index];
                Console.WriteLine(word.Split(" ")[1]);
                string c = Console.ReadLine();
                if(c == "id")
                {
                    Console.WriteLine(word.Split(" ")[0]);
                    c = Console.ReadLine();
                }
                if(c == "N" || c == "n")
                {  
                    continue;
                }
                else if(c == "R" || c == "r")
                {
                    Console.WriteLine($"There are {words.Count} words remaining");
                    Console.ReadLine();
                    continue;
                }
                words.RemoveAt(index);
                continue;
            }
        }
    }
}
