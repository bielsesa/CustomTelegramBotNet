namespace CustomTelegramBotNet.Types
{
    internal class CallbackQuery
    {
        private string id;
        private User from;
        private Message message;
        private string inlineMessageId;
        private string chatInstance;
        private string data;
        private string gameShortName;

        public string Id { get; set; }
        public User From { get; set; }
        public Message Message { get; set; }
        public string InlineMessageId { get; set; }
        public string ChatInstance { get; set; }
        public string Data { get; set; }
        public string GameShortName { get; set; }

    }
}