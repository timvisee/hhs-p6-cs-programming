using System;
using System.Collections.Generic;

namespace hhs_p6_cs_programming.exercises.quiz {
    public class OpenQuestion : BaseQuestion {

        /// <summary>
        /// List of possible answers, as strings.
        /// </summary>
        private List<string> _answers = new List<string>();

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
        public OpenQuestion(string question, List<string> answers) : base(question) {
            _answers = answers;
        }

        /// <summary>
        /// Get the list of answers.
        /// </summary>
        /// <returns>Answers.</returns>
        public List<string> GetAnswers() {
            return _answers;
        }

        public override void ShowInputPosibilities() {}

        public override void ShowInputHint() {
            Console.Write("Enter your answer [answer/CRTL+C]: ");
        }

        public override bool HandleAnswer() {
            // Print the input hint
            ShowInputHint();

            // TODO: Parse the answer input
            Console.ReadLine();
            return true;
        }

        public override bool IsConfigured() {
            // At least one answer must be configured
            if(_answers.Count <= 0)
                return false;

            // TODO: Make sure at least one of the answers is correct!
//            // Make sure at least one of the answers is correct
//            foreach(FixedAnswer answer in _answers)
//                if(answer.IsCorrect())
//                    return true;

            // No answer seems to be correct, the question is not configured properly
            return false;
        }

    }
}
