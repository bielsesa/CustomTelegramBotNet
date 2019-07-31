using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class PollOption
    {
        private string text;
        private int voterCount;

        public string Text { get; set; }
        public int VoterCount { get; set; }
    }
}
