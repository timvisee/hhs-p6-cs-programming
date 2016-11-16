using System;
using System.Collections.Generic;

namespace hhs_p6_cs_programming {
    public class Exercise_6_26 : BaseExercise {

        protected override string ExerciseIdentifier { get { return "6.26"; } }

        /// <summary>
        /// First list.
        /// </summary>
        private List<int> _a = new List<int>();

        /// <summary>
        /// Second list.
        /// </summary>
        private List<int> _b = new List<int>();

        /// <summary>
        /// Method to run the exercise.
        /// </summary>
        protected override void Run() {
            // Print the exercise
            Console.WriteLine("Exercise 6.26:");

            // Build two list
            BuildList(_a);
            BuildList(_b);
            PrintList(_a);
            PrintList(_b);

            // Append B to A
            Append(_a, _b);
            PrintList(_a);
        }

        /// <summary>
        /// Print the given list.
        /// </summary>
        /// <param name="list">List to print.</param>
        private void PrintList(List<int> list) {
            Console.WriteLine(string.Join(", ", list));
        }

        /// <summary>
        /// Fill the list with random numbers.
        /// </summary>
        /// <param name="list">List to fill.</param>
        private void BuildList(List<int> list) {
            // Create a random object
            Random rand = new Random();

            // Fill the list with 8 items
            for(int i = 0; i < 8; i++)
                list.Add(rand.Next(10, 100));
        }

        /// <summary>
        /// Append the given list to the root.
        /// </summary>
        /// <param name="root">Root list, the other list is appended to.</param>
        /// <param name="append">List to append to the root.</param>
        /// <returns>Root list, with the appended list.</returns>
        private List<int> Append(List<int> root, List<int> append) {
            // Append the given list to the root, and return it
            root.AddRange(append);
            return root;
        }

    }
}