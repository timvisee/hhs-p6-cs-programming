using System;

namespace hhs_p6_cs_programming.exercises.p6 {
    public class E2 : BaseExercise {

        protected override string ExerciseIdentifier { get { return "6.2"; } }

        /// <summary>
        /// Integer array this class works with.
        /// </summary>
        private static int[] _intArray;

        /// <summary>
        /// Random generator.
        /// </summary>
        private static readonly Random Rand = new Random();

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
            PrintArray("C. Zero even");

            // Largest neighbor
            LargestNeighbor();
            PrintArray("D. Largest neighbor");

            // Trim the middle element
            TrimMiddle();
            PrintArray("E. Trim middle");
        }

        /// <summary>
        /// Build and fill the integer array.
        /// </summary>
        private void BuildArray() {
            // Create a new int array
            _intArray = new int[8];

            // Fill the array with random numbers
            for(var i = 0; i < _intArray.Length; i++)
                _intArray[i] = Rand.Next(10, 100);
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

        /// <summary>
        /// Trim the middle element from the array.
        /// If the array has an even size, the middle two elements will be trimmed.
        ///
        /// Note: The array must contain at least 3 elements.
        /// </summary>
        public void TrimMiddle() {
            // Define a new array with the correct (trimmed) size
            int[] newArray = new int[_intArray.Length - 2 + (_intArray.Length % 2)];

            // Fill the array
            for(var i = 0; i < newArray.Length; i++)
                newArray[i] = i < newArray.Length / 2
                                  ? newArray[i] = _intArray[i]
                                  : _intArray[_intArray.Length - (newArray.Length - i)];

            // Update the array
            _intArray = newArray;
        }

    }
}