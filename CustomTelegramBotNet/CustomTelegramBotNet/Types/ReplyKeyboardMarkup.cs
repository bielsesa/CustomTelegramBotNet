using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class ReplyKeyboardMarkup
    {
        private KeyboardButton[] keyboard;
        private bool resizeKeyboard;
        private bool oneTimeKeyboard;
        private bool selective;

        public KeyboardButton[] Keyboard { get; set; }
        public bool ResizeKeyboard { get; set; }
        public bool OneTimeKeyboard { get; set; }
        public bool Selective { get; set; }
    }
}
