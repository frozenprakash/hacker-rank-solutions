using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/grading/problem
    /// </summary>
    internal static class GradingStudents
    {
        public static List<int> Execute(List<int> grades)
        {
            int grade,
            nextMultiple;
            List<int> newGrades = new List<int>();

            for(int i = 0;
                    i < grades.Count;
                    i++)
            {
                grade = grades[i];
                nextMultiple = ((grade / 5) + 1) * 5;

                if (grade >= 38 &&
                    nextMultiple - grade < 3)
                {
                    newGrades.Add(nextMultiple);
                }
                else
                {
                    newGrades.Add(grade);
                }
            }

            return newGrades;
        }
    }
}
