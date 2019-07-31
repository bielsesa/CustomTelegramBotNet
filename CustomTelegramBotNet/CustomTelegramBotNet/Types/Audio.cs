namespace CustomTelegramBotNet.Types
{
    internal class Audio
    {
        private string fileId;
        private int duration;
        private string performer;
        private string title;
        private string mimeType;
        private int fileSize;
        private PhotoSize thumb;
        
        public string FileId { get; set; }
        public int Duration { get; set; }
        public string Performer { get; set; }
        public string Title { get; set; }
        public string MimeType { get; set; }
        public int FileSize { get; set; }
        public PhotoSize Thumb { get; set; }

    }
}