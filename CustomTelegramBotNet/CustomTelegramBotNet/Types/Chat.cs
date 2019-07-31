using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class Chat
    {
        private int id;
        private string type;
        private string title;
        private string username;
        private string firstName;
        private string secondName;
        private ChatPhoto photo;
        private string description;
        private string inviteLink;
        private Message pinnedMessage;
        private ChatPermissions permissions;
        private string stickerSetName;
        private bool canSetStickerSet;

        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public ChatPhoto Photo { get; set; }
        public string Description { get; set; }
        public ChatPermissions Permissions { get; set; }
        public string StickerSetName { get; set; }
        public bool CanSetStickerSet { get; set; }
    }
}
