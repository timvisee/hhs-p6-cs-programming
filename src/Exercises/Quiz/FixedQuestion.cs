using System;
using System.Collections.Generic;

namespace hhs_p6_cs_programming.exercises.quiz {
    public class FixedQuestion : BaseQuestion {

        /// <summary>
        /// List of answers for this question.
        /// </summary>
        private List<FixedAnswer> _answers = new List<FixedAnswer>();

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="question">Question.</param>
        public FixedQuestion(string question) : base(question) {}

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="question">Question.</param>
        /// <param name="answers">List of answers.</param>
        public FixedQuestion(string question, List<FixedAnswer> answers) : base(question) {
            _answers = answers;
        }

        /// <summary>
        /// Get the list of answers.
        /// </summary>
        /// <returns>Answers.</returns>
        public List<FixedAnswer> GetAnswers() {
            return _answers;
        }

        public override void ShowInputPossibilities() {
            // Show the input header
            Console.Write("A:");

            // Show the answers
            for(var i = 0; i < _answers.Count; i++)
                Console.WriteLine(
                                  "{0} {1}. {2}",
                                  i != 0 ? "  " : "",
                                  (i + 1).ToString(),
                                  _answers[i].GetAnswer()
                                 );
        }

        public override void ShowInputHint() {
            // Determine what the input string should be
            string inputString = _answers.Count == 1 ? "1" : string.Format("1-{0}", _answers.Count);

            // Print the footer
            Console.Write("Enter your answer [{0}/CRTL+C]: ", inputString);
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

            // Make sure at least one of the answers is correct
            foreach(FixedAnswer answer in _answers)
                if(answer.IsCorrect())
                    return true;

            // No answer seems to be correct, the question is not configured properly
            return false;
        }

    }
}
