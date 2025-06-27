using System.Collections.Generic;

namespace CybersecurityChatbot.Logic
{
    public static class QuizManager
    {
        private static List<(string Question, string Answer)> questions = new()
        {
            ("What is phishing?", "a"),
            ("What should you do with suspicious links?", "b"),
            ("What does 2FA stand for?", "c"),
            ("Why update your software?", "d"),
            ("Which is safe: public Wi-Fi or VPN?", "c")
        };

        private static int currentQuestionIndex = -1;
        private static int score = 0;
        private static bool quizActive = false;

        public static string StartQuiz()
        {
            quizActive = true;
            currentQuestionIndex = 0;
            score = 0;
            return $"Quiz started! {GetCurrentQuestion()}";
        }

        public static string ProcessAnswer(string input)
        {
            if (!quizActive)
                return "No quiz is active. Type 'quiz' to start.";

            string correctAnswer = questions[currentQuestionIndex].Answer;
            string response;

            if (input.ToLower().Trim() == correctAnswer)
            {
                score++;
                response = "Correct!";
            }
            else
            {
                response = $"Incorrect. The correct answer was '{correctAnswer}'.";
            }

            currentQuestionIndex++;

            if (currentQuestionIndex >= questions.Count)
            {
                quizActive = false;
                return $"{response}\nQuiz finished! Your score: {score}/{questions.Count}";
            }

            return $"{response}\nNext: {GetCurrentQuestion()}";
        }

        public static bool IsQuizActive()
        {
            return quizActive;
        }

        private static string GetCurrentQuestion()
        {
            var (q, _) = questions[currentQuestionIndex];
            return $"Q{currentQuestionIndex + 1}: {q} (Answer with 'a', 'b', 'c', or 'd')";
        }
    }
}
