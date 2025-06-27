using System.Collections.Generic;

namespace CybersecurityChatbot.Logic
{
    public static class TaskManager
    {
        private static List<string> reminders = new();

        public static string AddReminder(string input)
        {
            reminders.Add(input);
            return $"Reminder added: {input}";
        }
    }
}
