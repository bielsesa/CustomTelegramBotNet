namespace CustomTelegramBotNet.Types
{
    internal class InlineKeyboardButton
    {
        private string text;
        private string url;
        private LoginUrl loginUrl;
        private string callbackData;
        private string switchInlineQuery;
        private string switchInlineQueryCurrentChat;
        private CallbackGame callbackGame;
        private bool pay;

        public string Text { get; set; }
        public string Url { get; set; }
        public LoginUrl LoginUrl { get; set; }
        public string CallbackData { get; set; }
        public string SwitchInlineQuery { get; set; }
        public string SwitchInlineQueryCurrentChat { get; set; }
        public CallbackGame CallbackGame { get; set; }
        public bool Pay { get; set; }

    }
}