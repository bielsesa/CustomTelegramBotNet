using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class InputMediaAnimation : InputMedia
    {
        private string thumbString;
        private InputFile thumbFile;
        private int width;
        private int height;
        private int duration;

        public string ThumbString { get; set; }
        public InputFile ThumbFile { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Duration { get; set; }
    }
}
