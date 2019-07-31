namespace CustomTelegramBotNet.Types
{
    internal class VideoNote
    {
        private string fileId;
        private int length;
        private int duration;
        private PhotoSize thumb;
        private int fileSize;

        public string FileId { get; set; }
        public int Length { get; set; }
        public int Duration { get; set; }
        public PhotoSize Thumb { get; set; }
        public int FileSize { get; set; }
    }
}