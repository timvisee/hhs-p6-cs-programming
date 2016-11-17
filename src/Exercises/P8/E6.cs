using System;

namespace hhs_p6_cs_programming.exercises.p8 {
    public class E6 : BaseExercise {

        protected override string ExerciseIdentifier {
            get {
                return "P8.6";
            }
        }

        /// <summary>
        /// Method to run the exercise.
        /// </summary>
        protected override void Run() {
            // Create a new car
            Car car = new Car(50);

            // Add 20 gallons of gas
            car.AddGas(20);

            // Drive 100 miles
            car.Drive(100);

            // Print the fuel remaining
            Console.WriteLine("Fuel remaining: {0} gallons", car.GetGas());
        }

        /// <summary>
        /// Car class.
        /// </summary>
        private class Car {

            /// <summary>
            /// Miles per gallon this car drives.
            /// </summary>
            private readonly float _milesPerGallon;

            /// <summary>
            /// Current number of gallons of gas in this car.
            /// </summary>
            private float _gas = 0;

            /// <summary>
            /// Car constructor.
            /// </summary>
            /// <param name="milesPerGallon">Miles per gallon of gas this car drives.</param>
            public Car(float milesPerGallon) {
                // Set the amount of miles per gallon
                this._milesPerGallon = milesPerGallon;
            }

            /// <summary>
            /// Add the given number of gallons of gas.
            /// </summary>
            /// <param name="gallons">Gallons of gas to add.</param>
            public void AddGas(float gallons) {
                this._gas += gallons;
            }

            /// <summary>
            /// Get the current gas level in gallons.
            /// </summary>
            /// <returns>Gas level in gallons.</returns>
            public float GetGas() {
                return this._gas;
            }

            /// <summary>
            /// Drive for the given number of miles.
            /// </summary>
            /// <param name="miles">Miles to drive.</param>
            public void Drive(float miles) {
                _gas = Math.Max(_gas - (miles / this._milesPerGallon), 0);
            }

        }

    }
}
