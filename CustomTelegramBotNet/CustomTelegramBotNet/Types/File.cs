using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class File
    {
        private string fileId;
        private int fileSize;
        private string filePath;

        public string FileId { get; set; }
        public int FileSize { get; set; }
        public string FilePath { get; set; }
    }
}
