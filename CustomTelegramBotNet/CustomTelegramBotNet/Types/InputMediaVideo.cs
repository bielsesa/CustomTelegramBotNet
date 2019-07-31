﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class InputMediaVideo : InputMedia
    {
        private string thumbString;
        private InputFile thumbFile;
        private int width;
        private int height;
        private int duration;
        private bool supportsStreaming;

        public string ThumbString { get; set; }
        public InputFile ThumbFile { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Duration { get; set; }
        public bool SupportsStreaming { get; set; }
    }
}
