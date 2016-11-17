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

            // Promote even elements
            PromoteEven();
            PrintArray("F. Promote even");

            // Get second largest
            Console.WriteLine("G. Second largest: {0}\n", GetSecondLargest());

            // Is array sorted
            Console.WriteLine("H. Is sorted: {0}\n", IsSorted());

            // Contains adjacent duplicates
            Console.WriteLine("I. Contains adjacent duplicate: {0}\n", ContainsAdjacentDuplicate());

            // Contains non-adjacent duplicates
            Console.WriteLine("J. Contains non-adjacent duplicate: {0}\n", ContainsNonAdjacentDuplicate());
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
        private void TrimMiddle() {
            // Define a buffer array for the operation, with the trimmed size
            int[] buff = new int[_intArray.Length - 2 + (_intArray.Length % 2)];

            // Fill the array
            for(var i = 0; i < buff.Length; i++)
                buff[i] = i < buff.Length / 2
                                  ? buff[i] = _intArray[i]
                                  : _intArray[_intArray.Length - (buff.Length - i)];

            // Apply the buffer
            _intArray = buff;
        }

        /// <summary>
        /// Promote all even elements of the array, and move them to the front.
        /// </summary>
        private void PromoteEven() {
            // Define a buffer array for the operation, and a variable to store the current array index
            int[] buff = new int[_intArray.Length];
            int n = 0;

            // Put all even elements in the front
            foreach(int e in _intArray)
                if(e % 2 == 0)
                    buff[n++] = e;

            // Put the other elements behind it
            foreach(int e in _intArray)
                if(e % 2 != 0)
                    buff[n++] = e;

            // Apply the buffer
            _intArray = buff;
        }

        /// <summary>
        /// Get the second largest element frmo the array.
        /// </summary>
        /// <returns>Second largest element.</returns>
        private int GetSecondLargest() {
            // Define an array for the largest, and second largest
            int l = _intArray[0], s = _intArray[0];

            // Loop through the array, and update the (second) largest numbers
            for(var i = 1; i < _intArray.Length; i++)
                if(_intArray[i] >= l) {
                    s = l;
                    l = _intArray[i];

                }  else if(_intArray[i] > s)
                    s = _intArray[i];

            // Return the second largest value
            return s;
        }

        /// <summary>
        /// Check whether the array elements are sorted in increasing order.
        /// </summary>
        /// <returns>True if sorted, false if not.</returns>
        private bool IsSorted() {
            // The array isn't sorted if the previous element is larger than the current
            for(var i = 1; i < _intArray.Length; i++)
                if(_intArray[i - 1] > _intArray[i])
                    return false;

            // The array seems to be sorted
            return true;
        }

        /// <summary>
        /// Check whether the array contains any adjacent duplicate values.
        /// </summary>
        /// <returns>True if it contains adjacent duplicate values.</returns>
        private bool ContainsAdjacentDuplicate() {
            // Check whether adjacent values are equal
            for(var i = 1; i < _intArray.Length; i++)
                if(_intArray[i - 1] == _intArray[i])
                    return true;

            // Doesn't seem to contain adjacent duplicates, return
            return false;
        }

        /// <summary>
        /// Check whether the array contains any duplicate values, that are not adjacent to each other.
        /// </summary>
        /// <returns>True if it contains non-adjacent duplicate values.</returns>
        private bool ContainsNonAdjacentDuplicate() {
            // Check whether non-adjacent values are equal
            for(var i = 2; i < _intArray.Length; i++)
                // Loop through the items before this, except the adjacent one
                for(var j = 0; j < i - 1; j++)
                    if(_intArray[i] == _intArray[j])
                        return true;

            // Doesn't seem to contain non-adjacent duplicates, return
            return false;
        }

    }
}