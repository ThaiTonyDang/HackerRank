using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingStudent
{
    internal class Program
    {
        public static List<int> GradingStudent(List<int> grades)
        {
            List<int> finalScores = new List<int>();
            foreach (var grade in grades)
            {
                if (grade % 5 < 3
                    || grade < 38)
                {
                    finalScores.Add(grade);
                }
                else
                {
                    finalScores.Add(grade + (5 - grade % 5));
                }
            }

            return finalScores;
        }

        public static List<int> GradingScoreStudent(List<int> grades)
        {
            return grades.Select(grade =>
            {
                if (grade % 5 < 3
                    || grade < 38)
                {
                    return grade;
                }
                return grade + (5 - grade % 5);
            }).ToList();
        }

        static void Main(string[] args)
        {
            List<int> scores = new List<int> { 4, 73, 67, 38, 33 };
            List<int> finalScores = GradingScoreStudent(scores);
            foreach (var item in finalScores)
            {
                Console.WriteLine(item);
            }
        }
    }
}