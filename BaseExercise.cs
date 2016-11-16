namespace hhs_p6_cs_programming {
    public abstract class BaseExercise {

        /// <summary>
        /// Exercise identifier, such as "6.26".
        /// </summary>
        public abstract string ExerciseIdentifier { get; }

        /// <summary>
        /// Run the exercise.
        /// </summary>
        public abstract void Run();

    }
}