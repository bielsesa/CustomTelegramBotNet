using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class Document
    {
        private string fileId;
        private PhotoSize thumb;
        private string fileName;
        private string mimeType;
        private int fileSize;

        public string FileId { get; set; }
        public PhotoSize Thumb { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public int FileSize { get; set; }
    }
}
