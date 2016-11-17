using System;
using System.Collections.Generic;

namespace hhs_p6_cs_programming.exercises.p9 {
    public class E8 : BaseExercise {

        protected override string ExerciseIdentifier {
            get {
                return "P9.8";
            }
        }

        /// <summary>
        /// Method to run the exercise.
        /// </summary>
        protected override void Run() {
            // Create a random object for random generation
            Random rand = new Random();

            // Create a list and put some persons in it, and a name index
            List<IPerson> people = new List<IPerson>();
            int nameNumber = 1;

            // Add some persons
            for(int i = 0, amount = rand.Next(3, 8); i < amount; i++)
                people.Add(new Person(
                                      string.Format("Name{0}", nameNumber++.ToString()),
                                      rand.Next(100)
                                     ));

            // Add some students
            for(int i = 0, amount = rand.Next(3, 8); i < amount; i++)
                people.Add(new Student(
                                       string.Format("Name{0}", nameNumber++.ToString()),
                                       rand.Next(100),
                                       string.Format("Major{0}", rand.Next(1, 5).ToString())
                                      ));

            // Add some instructors
            for(int i = 0, amount = rand.Next(3, 8); i < amount; i++)
                people.Add(new Instructor(
                                          string.Format("Name{0}", nameNumber++.ToString()),
                                          rand.Next(100),
                                          (decimal) (100 + rand.NextDouble() * 900)
                                         ));

            // Print the list of people
            Console.WriteLine("People:");
            foreach(IPerson person in people)
                Console.WriteLine("- {0}", person);
        }

        /// <summary>
        /// Person interface.
        /// </summary>
        private interface IPerson {

            /// <summary>
            /// Get the person's name.
            /// </summary>
            /// <returns>Name.</returns>
            string GetName();

            /// <summary>
            /// Get the person's age.
            /// </summary>
            /// <returns>Age.</returns>
            int GetAge();

            /// <summary>
            /// Get the person as string representation.
            /// </summary>
            /// <returns>Person as string representation.</returns>
            string ToString();

        }

        /// <summary>
        /// Student interface.
        /// </summary>
        private interface IStudent : IPerson {

            /// <summary>
            /// Get the major the user has.
            /// </summary>
            /// <returns>Major.</returns>
            string GetMajor();

        }

        /// <summary>
        /// Instructor interface.
        /// </summary>
        private interface IInstructor : IPerson {

            /// <summary>
            /// Salary of the instructor.
            /// </summary>
            /// <returns>Salary.</returns>
            decimal GetSalary();

            /// <summary>
            /// Get the salary of the instructor, as a formatted string.
            /// </summary>
            /// <returns>Salary as a formatted string.</returns>
            string GetSalaryFormatted();

        }

        /// <summary>
        /// Person class.
        /// </summary>
        private class Person : IPerson {

            /// <summary>
            /// Person's name.
            /// </summary>
            private readonly string _name;

            /// <summary>
            /// Person's age in years.
            /// </summary>
            private readonly int _age;

            /// <summary>
            /// Person constructor.
            /// </summary>
            /// <param name="name">Name.</param>
            /// <param name="age">Age in years.</param>
            public Person(string name, int age) {
                _name = name;
                _age = age;
            }

            public string GetName() {
                return _name;
            }

            public int GetAge() {
                return _age;
            }

            /// <summary>
            /// Get the property string for this person.
            /// </summary>
            /// <returns>Property string.</returns>
            protected virtual string GetPropertyString() {
                return string.Format(
                                     "name: {0}, age: {1}",
                                     GetName(),
                                     GetAge().ToString()
                                    );
            }

            public override String ToString() {
                // Define a variable for the properties, and get them if the person is old enough
                string properties = "Anonymous";
                if(_age >= 16)
                    properties = GetPropertyString();

                // Format and return the string
                return string.Format(
                                     "{0}({1})",
                                     GetType().Name,
                                     properties
                                    );
            }

        }

        /// <summary>
        /// Student class.
        /// </summary>
        private class Student : Person, IStudent {

            /// <summary>
            /// Major of the student.
            /// </summary>
            private readonly string _major;

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="name">Name.</param>
            /// <param name="age">Age in years.</param>
            /// <param name="major">Major of the student.</param>
            public Student(string name, int age, string major) : base(name, age) {
                _major = major;
            }

            public string GetMajor() {
                return _major;
            }

            protected override string GetPropertyString() {
                return string.Format(
                                     "{0}, major: {1}",
                                     base.GetPropertyString(),
                                     GetMajor()
                                    );
            }

        }

        /// <summary>
        /// Instructor class.
        /// </summary>
        private class Instructor : Person, IInstructor {

            /// <summary>
            /// Salary of the instructor.
            /// </summary>
            private readonly decimal _salary;

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="name">Name.</param>
            /// <param name="age">Age in years.</param>
            /// <param name="salary">Salary.</param>
            public Instructor(string name, int age, decimal salary) : base(name, age) {
                _salary = salary;
            }

            public decimal GetSalary() {
                return _salary;
            }

            public string GetSalaryFormatted() {
                return _salary.ToString("C");
            }

            protected override string GetPropertyString() {
                return string.Format(
                                     "{0}, salary: {1}",
                                     base.GetPropertyString(),
                                     GetSalaryFormatted()
                                    );
            }

        }

    }
}
