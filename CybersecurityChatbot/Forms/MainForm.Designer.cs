namespace CybersecurityChatbot.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.RichTextBox rtbConversation;

        private void InitializeComponent()
        {
            txtInput = new System.Windows.Forms.TextBox();
            btnSend = new System.Windows.Forms.Button();
            btnQuiz = new System.Windows.Forms.Button();
            btnViewLog = new System.Windows.Forms.Button();
            rtbConversation = new System.Windows.Forms.RichTextBox();

            txtInput.Location = new System.Drawing.Point(12, 12);
            txtInput.Size = new System.Drawing.Size(400, 23);

            btnSend.Text = "Send";
            btnSend.Location = new System.Drawing.Point(420, 12);
            btnSend.Click += btnSend_Click;

            btnQuiz.Text = "Start Quiz";
            btnQuiz.Location = new System.Drawing.Point(12, 45);
            btnQuiz.Click += btnQuiz_Click;

            btnViewLog.Text = "View Log";
            btnViewLog.Location = new System.Drawing.Point(100, 45);
            btnViewLog.Click += btnViewLog_Click;

            rtbConversation.Location = new System.Drawing.Point(12, 80);
            rtbConversation.Size = new System.Drawing.Size(480, 300);

            Controls.Add(txtInput);
            Controls.Add(btnSend);
            Controls.Add(btnQuiz);
            Controls.Add(btnViewLog);
            Controls.Add(rtbConversation);

            Text = "Cybersecurity Chatbot";
            ClientSize = new System.Drawing.Size(500, 400);
        }
    }
}
