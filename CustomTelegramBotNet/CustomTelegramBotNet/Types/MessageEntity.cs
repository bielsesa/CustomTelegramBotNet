namespace CustomTelegramBotNet.Types
{
    internal class MessageEntity
    {
        private string type;
        private int offset;
        private int length;
        private string url;
        private User user;
        
        public string Type { get; set; }
        public int Offset { get; set; }
        public int Length { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
    }
}