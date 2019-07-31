using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class InputMediaDocument : InputMedia
    {
        private string thumbString;
        private InputFile thumbFile;

        public string ThumbString { get; set; }
        public InputFile ThumbFile { get; set; }
    }
}
