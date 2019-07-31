namespace CustomTelegramBotNet
{
    internal class Voice
    {
        private string fileId;
        private int duration;
        private string mimeType;
        private int fileSize;

        public string FileId { get; set; }
        public int Duration { get; set; }
        public string MimeType { get; set; }
        public int FileSize { get; set; }
    }
}