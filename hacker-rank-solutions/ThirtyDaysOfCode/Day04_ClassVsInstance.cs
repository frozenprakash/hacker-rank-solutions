using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-class-vs-instance/problem
    /// </summary>
    internal class Day04_ClassVsInstance
    {
        public class Person
        {
            public int age;
            public Person(int initialAge)
            {
                // Add some more code to run some checks on initialAge
                if (initialAge < 0)
                {
                    age = 0;
                    Console.WriteLine("Age is not valid, setting age to 0.");
                }
                else
                {
                    age = initialAge;
                }
            }

            public void amIOld()
            {
                // Do some computations in here and print out the correct statement to the console 
                if (age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                else if (age >= 13 && age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are old.");
                }
            }

            public void yearPasses()
            {
                // Increment the age of the person in here
                age++;
            }

        }
    }
}