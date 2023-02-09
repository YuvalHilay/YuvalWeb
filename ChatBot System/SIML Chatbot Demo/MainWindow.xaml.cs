using System.IO;
using System.Windows;
using Syn.Bot;

namespace SIML_Chatbot_Demo
{
    public partial class MainWindow
    {
        public SynBot Chatbot;
        public MainWindow()
        {
            InitializeComponent();
            Chatbot = new SynBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
        }

        private void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Chatbot.Chat(InputBox.Text);
            OutputBox.Text = string.Format("User: {0}\nBot: {1}\n{2}", InputBox.Text, result.BotMessage, OutputBox.Text);
            InputBox.Text = string.Empty;
        }
    }
}
