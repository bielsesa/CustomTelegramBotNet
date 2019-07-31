using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class ChatPhoto
    {
        private string smallFileId;
        private string bigFileId;

        public string SmallFileId { get; set; }
        public string BigFileId { get; set; }
    }
}
