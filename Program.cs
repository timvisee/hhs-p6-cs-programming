using System;

namespace hhs_p6_cs_programming {
    public static class Program {

        /// <summary>
        /// Application name.
        /// </summary>
        private const string AppName = "HHS P6 C# Programming";

        /// <summary>
        /// Main method, to start the program.
        /// </summary>
        public static void Main() {
            // Print the program name
            Console.WriteLine("{0}\n", AppName);

            // Create a new exercise instance
            new Exercise_6_2().Start();
        }

    }
}