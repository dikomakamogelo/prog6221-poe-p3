namespace CybersecurityChatbot.Logic
{
    public static class NLPProcessor
    {
        public static string GetBotResponse(string input)
        {
            if (input.Contains("remind"))
                return TaskManager.AddReminder(input);
            if (input.Contains("quiz"))
                return QuizManager.StartQuiz();
            return CybersecurityKnowledgeBase.GetAdvice(input);
        }
    }
}
