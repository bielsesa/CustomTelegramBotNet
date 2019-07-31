namespace CustomTelegramBotNet.Types
{
    internal class Video
    {
        private string fileId;
        private int width;
        private int height;
        private int duration;
        private PhotoSize thumb;
        private string mimeType;
        private int fileSize;

        public string FileId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Duration { get; set; }
        public PhotoSize Thumb { get; set; }
        public string MimeType { get; set; }
        public int FileSize { get; set; }
    }
}