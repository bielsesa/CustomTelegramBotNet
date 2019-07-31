namespace CustomTelegramBotNet.Types
{
    internal class LoginUrl
    {
        private string url;
        private string forwardText;
        private string botUsername;
        private bool requestWriteAccess;

        public string Url { get; set; }
        public string ForwardText { get; set; }
        public string BotUsername { get; set; }
        public bool RequestWriteAccess { get; set; }
    }
}