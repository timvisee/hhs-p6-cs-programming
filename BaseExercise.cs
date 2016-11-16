using System;

namespace hhs_p6_cs_programming {
    public abstract class BaseExercise {

        /// <summary>
        /// Exercise identifier, such as "6.26".
        /// </summary>
        protected abstract string ExerciseIdentifier { get; }

        /// <summary>
        /// Start the exercise.
        /// </summary>
        public void Start() {
            // Print the exercise in the console
            Console.WriteLine("# Exercise P{0}:\n", ExerciseIdentifier);

            // Run the exercise
            Run();
        }

        /// <summary>
        /// Run the exercise.
        /// </summary>
        protected abstract void Run();

    }
}