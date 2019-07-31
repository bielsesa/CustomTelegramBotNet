using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    abstract class InputMedia
    {
        private string type;
        private string media;
        private string caption;
        private string parseMode;

        public string Type { get; set; }
        public string Media { get; set; }
        public string Caption { get; set; }
        public string ParseMode { get; set; }
    }
}
