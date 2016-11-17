using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace hhs_p6_cs_programming.exercises.quiz {
    public class Quiz : BaseExercise {

        protected override string ExerciseIdentifier {
            get {
                return "Quiz";
            }
        }

        /// <summary>
        /// List of questions in this quiz.
        /// </summary>
        private List<BaseQuestion> _questions = new List<BaseQuestion>();

        /// <summary>
        /// Method to run the exercise.
        /// </summary>
        protected override void Run() {
            // Add some test questions
            List<FixedAnswer> fixedAnswers = new List<FixedAnswer>();
            fixedAnswers.Add(new FixedAnswer("Letter D", true));
            fixedAnswers.Add(new FixedAnswer("Letter C", false));
            fixedAnswers.Add(new FixedAnswer("Letter B", false));
            fixedAnswers.Add(new FixedAnswer("Letter G", false));

            // Create a question and add it to the list
            _questions.Add(new FixedQuestion("What letter comes after C in the alphabet?", fixedAnswers));

            List<OpenAnswer> openAnswers = new List<OpenAnswer>();
            openAnswers.Add(new OpenAnswer("1"));

            // Create a question and add it to the list
            _questions.Add(new OpenQuestion("How many quizzes are you playing right now?", openAnswers));

            // Run the quiz
            RunQuiz();
        }

        /// <summary>
        /// Run the quiz.
        /// </summary>
        public void RunQuiz() {
            // Keep track of the number of correct answers and total questions
            int correct = 0;
            int total = 0;

            // Loop through the questions
            for(var i = 0; i < _questions.Count; i++) {
                // Get the question
                BaseQuestion question = _questions[i];

                // Skip the question if the question hasn't been fully configured yet
                if(!question.IsConfigured()) {
                    Console.WriteLine("Skipped question {0} as it hasn't been fully configured yet.", i.ToString());
                    continue;
                }

                // Increase the question counter
                total++;

                // Do the question, and handle the output
                if(question.DoQuestion())
                    correct++;
            }

            // Print the quiz footer
            Console.WriteLine(
                              "Quiz finished! You had {0} of {1} questions correct.",
                              correct.ToString(),
                              total.ToString()
                             );
        }

    }
}
