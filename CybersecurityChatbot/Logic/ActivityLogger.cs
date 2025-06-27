using System.Collections.Generic;

namespace CybersecurityChatbot.Logic
{
    public static class ActivityLogger
    {
        private static List<string> logs = new();

        public static void Log(string userInput, string response)
        {
            logs.Add($"User: {userInput} -> Bot: {response}");
            if (logs.Count > 50) logs.RemoveAt(0);
        }

        public static string GetLog()
        {
            return string.Join("\n", logs);
        }
    }
}
