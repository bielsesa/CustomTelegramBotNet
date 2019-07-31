using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class UserProfilePhotos
    {
        private int totalCount;
        private PhotoSize[] photos;

        public int TotalCount { get; set; }
        public PhotoSize[] Photos { get; set; }
    }
}
