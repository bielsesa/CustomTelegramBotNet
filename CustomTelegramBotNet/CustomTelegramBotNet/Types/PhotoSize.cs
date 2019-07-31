namespace CustomTelegramBotNet.Types
{
    internal class PhotoSize
    {
        private string fileId;
        private int width;
        private int height;
        private int fileSize;

        public string FileId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int FileSize { get; set; }       
    }
}