using System;
using System.Collections.Generic;

namespace hhs_p6_cs_programming.exercises.quiz {
    public class OpenQuestion : BaseQuestion {

        /// <summary>
        /// List of possible answers, as strings.
        /// </summary>
        private List<OpenAnswer> _answers = new List<OpenAnswer>();

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="question">Question.</param>
        public OpenQuestion(string question) : base(question) {}

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="question">Question.</param>
        /// <param name="answers">List of answers.</param>
        public OpenQuestion(string question, List<OpenAnswer> answers) : base(question) {
            _answers = answers;
        }

        /// <summary>
        /// Get the list of answers.
        /// </summary>
        /// <returns>Answers.</returns>
        public List<OpenAnswer> GetAnswers() {
            return _answers;
        }

        public override void ShowInputPossibilities() {
            Console.WriteLine("A: Enter your own answer...");
        }

        public override void ShowInputHint() {
            Console.Write("Your answer [answer/CRTL+C]: ");
        }

        public override bool IsCorrectAnswer(string answer) {
            // Make sure anything is given
            if(answer.Trim().Length == 0)
                throw new Exception("No answer given");

            // Loop through the answers, and check whether the given answer is correct
            foreach(OpenAnswer a in _answers)
                if(a.IsAnswer(answer))
                    return true;

            // The answer doesn't seem to be valid
            return false;
        }

        public override bool IsConfigured() {
            return _answers.Count > 0;
        }

    }
}
