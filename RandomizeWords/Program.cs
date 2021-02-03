using System;
using System.Collections.Generic;
using System.Linq;
namespace RandomizeWords
{
    class Program
    {


        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int k = rnd.Next(0, text.Length);
                string randomEl = text[k];
                string el = text[i];
                text[k] = el;
                text[i] = randomEl;
            }
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
