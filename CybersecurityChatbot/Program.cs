using System;
using System.Windows.Forms;
using CybersecurityChatbot.Forms;

namespace CybersecurityChatbot
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
