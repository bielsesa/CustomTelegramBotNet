using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class ResponseParameters
    {
        private int migrateToChatId;
        private int retryAfter;

        public int MigrateToChatId { get; set; }
        public int RetryAfter { get; set; }
    }
}
