using System.Collections.Generic;

namespace CybersecurityChatbot.Logic
{
    public static class QuizManager
    {
        private static List<(string Question, string[] Options, string Answer)> questions = new()
        {
            ("What is phishing?", new [] {"a) A cyber attack", "b) A type of fish", "c) A strong password", "d) A safe practice"}, "a"),
            ("What should you do with suspicious links?", new [] {"a) Click immediately", "b) Delete or ignore them", "c) Forward to friends", "d) Reply to the sender"}, "b"),
            ("What does 2FA stand for?", new [] {"a) Two-Factor Antivirus", "b) Two-Factor Attack", "c) Two-Factor Authentication", "d) Two-Faced Alert"}, "c"),
            ("Why update your software?", new [] {"a) To get viruses", "b) To fix security flaws", "c) To make computer slower", "d) No reason"}, "b"),
            ("Which is safer for sensitive tasks?", new [] {"a) Public Wi-Fi", "b) No Wi-Fi", "c) VPN connection", "d) Shared computer"}, "c")
        };

        private static int currentQuestionIndex = -1;
        private static int score = 0;
        private static bool quizActive = false;

        public static string StartQuiz()
        {
            quizActive = true;
            currentQuestionIndex = 0;
            score = 0;
            return $"Quiz started!\n{GetCurrentQuestion()}";
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

            return $"{response}\nNext:\n{GetCurrentQuestion()}";
        }

        public static bool IsQuizActive()
        {
            return quizActive;
        }

        private static string GetCurrentQuestion()
        {
            var (q, options, _) = questions[currentQuestionIndex];
            return $"Q{currentQuestionIndex + 1}: {q}\n{string.Join("\n", options)}\n(Answer with 'a', 'b', 'c', or 'd')";
        }
    }
}
