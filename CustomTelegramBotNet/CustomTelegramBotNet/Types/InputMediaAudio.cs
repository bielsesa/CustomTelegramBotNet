using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class InputMediaAudio : InputMedia
    {
        private string thumbString;
        private InputFile thumbFile;
        private int duration;
        private string performer;
        private string title;

        public string ThumbString { get; set; }
        public InputFile ThumbFile { get; set; }
        public int Duration { get; set; }
        public string Performer { get; set; }
        public string Title { get; set; }
    }
}
