﻿namespace hhs_p6_cs_programming.exercises.quiz {
    public class FixedAnswer {

        /// <summary>
        /// An answer.
        /// </summary>
        private string _answer;

        /// <summary>
        /// Defines whether this answer is correct or not.
        /// True if the answer is correct, false if not.
        /// </summary>
        private bool _correct;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="answer">Answer text.</param>
        /// <param name="correct">True if this answer is correct, false if not.</param>
        public FixedAnswer(string answer, bool correct) {
            _answer = answer;
            _correct = correct;
        }

        /// <summary>
        /// Get the answer text.
        /// </summary>
        /// <returns>Answer text.</returns>
        public string GetAnswer() {
            return _answer;
        }

        /// <summary>
        /// Check whether this answer is correct.
        /// </summary>
        /// <returns>True if correct, false if not.</returns>
        public bool IsCorrect() {
            return _correct;
        }

        /// <summary>
        /// Set whether this answer is correct.
        /// </summary>
        /// <param name="correct"></param>
        public void SetCorrect(bool correct) {
            _correct = correct;
        }

    }
}