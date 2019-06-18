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

        public void ThirdProblem()
        {
            //3.Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
            //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
            //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
            List<string> grades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            List<double> gradeAverages = new List<double>();
            foreach (string grade in grades)
            {
                string [] studentGradeAray = grade.Split(',');
                int[] intStudentGradeArray = Array.ConvertAll(studentGradeAray, g => int.Parse(g));
                List<int> shorterIntStudentGradeArray = new List<int>();
                for (int i = 0; i < intStudentGradeArray.Length; i++)
                {
                    if (intStudentGradeArray[i] != intStudentGradeArray.Min())
                    {
                        shorterIntStudentGradeArray.Add(intStudentGradeArray[i]);
                    }
                }
                double studentGradeAverage = shorterIntStudentGradeArray.Average();
                gradeAverages.Add(studentGradeAverage);
            }
            double classGradeAverages = gradeAverages.Average();
            Console.WriteLine(classGradeAverages);
        }

        public void FourthProblem()
        {
            //4. Write a function that takes in a string of letters (i.e. “Terrill”) 
            //and returns an alphabetically ordered string corresponding to the letter frequency (i.e. "E1I1L2R2T1")
            Console.WriteLine("Enter the string.");
            string result = "";
            string s = Console.ReadLine();
            var counts = s.GroupBy(c => c).ToDictionary(grp => grp.Key, grp => grp.Count()).OrderBy(c => c.Key);
            //var counts = s.GroupBy(c => c).Select(g => new { Letter = g.Key, Count = g.Count() }).ToList();
            foreach (var item in counts)
            {
                result += item.Letter.ToString();
                result += item.Count.ToString();                
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
