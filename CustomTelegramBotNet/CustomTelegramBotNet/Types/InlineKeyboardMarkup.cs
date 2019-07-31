using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class InlineKeyboardMarkup
    {
        private InlineKeyboardButton[] inlineKeyboard;

        public InlineKeyboardButton[] InlineKeyboard { get; set; }
    }
}
