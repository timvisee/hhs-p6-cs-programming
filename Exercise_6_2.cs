using System;

namespace hhs_p6_cs_programming {
    public class Exercise_6_2 : BaseExercise {

        protected override string ExerciseIdentifier { get { return "6.2"; } }

        /// <summary>
        /// Integer array this class works with.
        /// </summary>
        private static int[] _intArray;

        /// <summary>
        /// Method to run the exercise.
        /// </summary>
        protected override void Run() {
            // Build the array and print it
            BuildArray();
            PrintArray("Initial array");

            // Flip the first and last values and print it
            FlipFirstLast();
            PrintArray("A. Flip first & last");

            // Rotate the array
            Rotate();
            PrintArray("B. Rotate");

            // Zero even elements
            ZeroEven();
            PrintArray("C. Zero Even");

            // Largest neighbor
            LargestNeighbor();
            PrintArray("D. Largest Neighbor");
        }

        /// <summary>
        /// Build and fill the integer array.
        /// </summary>
        private void BuildArray() {
            // Create a new random object
            Random rand = new Random();

            // Create a new int array
            _intArray = new int[8];

            // Fill the array with random numbers
            for(var i = 0; i < _intArray.Length; i++)
                _intArray[i] = rand.Next(10, 100);
        }

        /// <summary>
        /// Print the current array in the console.
        /// </summary>
        private void PrintArray(string message) {
            // Print the message and the array to the console
            Console.WriteLine("{0}:\n{1}\n", message, string.Join(", ", _intArray));
        }

        /// <summary>
        /// Flip the first number in an integer array with the last.
        /// </summary>
        private void FlipFirstLast() {
            // Store the first variable
            int first = _intArray[0];

            // Flip the first and last values
            _intArray[0] = _intArray[_intArray.Length - 1];
            _intArray[_intArray.Length - 1] = first;
        }

        /// <summary>
        /// Rotate the array.
        /// </summary>
        private void Rotate() {
            // Store the last value
            int last = _intArray[_intArray.Length - 1];

            // Shift all elements, starting with the last
            for(var i = _intArray.Length - 1; i > 0; i--)
                _intArray[i] = _intArray[i - 1];

            // Set the first value to the original last value
            _intArray[0] = last;
        }

        /// <summary>
        /// Repalce all even elements with zero.
        /// </summary>
        private void ZeroEven() {
            // Loop thorugh the array
            for(var i = 0; i < _intArray.Length; i++)
                // Replace even elements with zero
                if(_intArray[i] % 2 == 0)
                    _intArray[i] = 0;
        }

        /// <summary>
        /// Replace each element with the largest of it's two neighbors.
        /// The first and last element are ignored.
        /// </summary>
        private void LargestNeighbor() {
            // Loop through the elements, and choose the largest neighbor
            for(var i = 1; i < _intArray.Length - 1; i++)
                _intArray[i] = Math.Max(_intArray[i - 1], _intArray[i + 1]);
        }

    }
}