using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problems
    {
        public void FirstProblem()
        {
            //1.Using LINQ, write a function that returns all words that contain the substring “th” from a list.
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> wordsTh = words.Where(w => w.Contains("th")).ToList();
            foreach (string word in wordsTh)
            {
                Console.WriteLine(word);
            }
        }

        public void SecondProblem()
        {
            //2.Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> namesUnique = names.Distinct().ToList();
            foreach (string word in namesUnique)
            {
                Console.WriteLine(word);
            }
        }
    }
}
