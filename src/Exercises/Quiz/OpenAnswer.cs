using System;

namespace hhs_p6_cs_programming.exercises.quiz {
    public class OpenAnswer {

        /// <summary>
        /// An answer.
        /// </summary>
        private string _answer;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="answer">Answer text.</param>
        public OpenAnswer(string answer) {
            _answer = answer;
        }

        /// <summary>
        /// Get the answer text.
        /// </summary>
        /// <returns>Answer text.</returns>
        public string GetAnswer() {
            return _answer;
        }

        /// <summary>
        /// Check whether the given answer is correct.
        /// The given answer is trimmed, and comapred with case insensitivity.
        /// </summary>
        /// <param name="answer">Answer to test.</param>
        /// <returns>True if the answer is correct, false if not.</returns>
        public bool IsAnswer(string answer) {
            return _answer.Trim().Equals(answer.Trim(), StringComparison.InvariantCultureIgnoreCase);
        }

    }
}