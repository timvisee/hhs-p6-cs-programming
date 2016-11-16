using System;

namespace hhs_p6_cs_programming {
    public static class Program {

        /// <summary>
        /// Application name.
        /// </summary>
        private const string AppName = "HHS P6 C# Programming";

        /// <summary>
        /// Developer name.
        /// </summary>
        private const string DeveloperName = "Tim Visee";

        /// <summary>
        /// Main method, to start the program.
        /// </summary>
        public static void Main() {
            // Print the program name
            Console.WriteLine("{0}\nDeveloped by {1}\n", AppName, DeveloperName);

            // Create and run an exercise
            new hhs_p6_cs_programming.exercises.p6.E2().Start();
        }

    }
}