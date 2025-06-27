namespace CybersecurityChatbot.Logic
{
    public static class CybersecurityKnowledgeBase
    {
        public static string GetAdvice(string input)
        {
            input = input.ToLower();
            if (input.Contains("phishing"))
                return "Phishing is when attackers trick you into giving information. Never click suspicious links.";
            if (input.Contains("2fa") || input.Contains("two-factor"))
                return "Two-Factor Authentication adds extra security. Enable it whenever possible.";
            if (input.Contains("malware"))
                return "Use antivirus and avoid shady downloads to prevent malware.";
            if (input.Contains("password"))
                return "Use strong, unique passwords. Never reuse them.";
            return "I can help with phishing, 2FA, malware, and password safety. Ask me!";
        }
    }
}
