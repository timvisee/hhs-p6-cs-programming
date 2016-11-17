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
            List<FixedAnswer> answers = new List<FixedAnswer>();
            answers.Add(new FixedAnswer("Answer 1", false));
            answers.Add(new FixedAnswer("Answer 2", false));
            answers.Add(new FixedAnswer("Answer 3", true));
            answers.Add(new FixedAnswer("Answer 4", false));

            // Create a question
            FixedQuestion question = new FixedQuestion("Question 1", answers);

            // Add the question
            _questions.Add(question);

            // Run the quiz
            RunQuiz();
        }

        /// <summary>
        /// Run the quiz.
        /// </summary>
        public void RunQuiz() {
            // Loop through the questions
            for(var i = 0; i < _questions.Count; i++) {
                // Get the question
                BaseQuestion question = _questions[i];

                // Skip the question if the question hasn't been fully configured yet
                if(!question.IsConfigured()) {
                    Console.WriteLine("Skipped question {0} as it hasn't been fully configured yet.", i.ToString());
                    continue;
                }

                // Print the question and answers
                question.ShowQuestion();
                question.ShowInputHint();
            }
        }

    }
}
