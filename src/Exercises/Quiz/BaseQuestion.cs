using System;

namespace hhs_p6_cs_programming.exercises.quiz {
    public abstract class BaseQuestion {

        /// <summary>
        /// Question.
        /// </summary>
        private string _question;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="question">Question.</param>
        protected BaseQuestion(string question) {
            _question = question;
        }

        /// <summary>
        /// Get the question.
        /// </summary>
        /// <returns>Get the question.</returns>
        public string GetQuestion() {
            return _question;
        }

        /// <summary>
        /// Show the question in the console.
        /// </summary>
        public void ShowQuestion() {
            Console.WriteLine("Q: {0}", GetQuestion());
        }

        /// <summary>
        /// Show all input posibilities.
        /// </summary>
        public abstract void ShowInputPossibilities();

        /// <summary>
        /// Show the input hint for the current question.
        /// This might give a list of possible answers, or might say that an answer should be entered.
        /// </summary>
        public abstract void ShowInputHint();

        /// <summary>
        /// Hint the user for input, and handle the user's input.
        /// </summary>
        /// <returns>True if the user was correct, false if not.</returns>
        public abstract bool HandleAnswer();

        /// <summary>
        /// Do the question.
        /// This shows the question on the screen, and parses the output.
        /// </summary>
        /// <returns>True if the answer was correct, false if not.</returns>
        public bool DoQuestion() {
            // Show the question
            ShowQuestion();

            // Show the input posibilities
            ShowInputPossibilities();

            // Hanlde the answer
            return HandleAnswer();
        }

        /// <summary>
        /// Check whether this question is properly configured.
        /// </summary>
        /// <returns>True if the question is properly configurered, false if not.</returns>
        public abstract bool IsConfigured();

    }
}