using System;
using System.Windows.Forms;
using CybersecurityChatbot.Logic;

namespace CybersecurityChatbot.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string response = NLPProcessor.GetBotResponse(input);
            rtbConversation.AppendText($"You: {input}\nBot: {response}\n\n");
            ActivityLogger.Log(input, response);
            txtInput.Clear();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            string response = QuizManager.StartQuiz();
            rtbConversation.AppendText($"Bot: {response}\n\n");
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            string logs = ActivityLogger.GetLog();
            MessageBox.Show(logs, "Activity Log");
        }
    }
}
