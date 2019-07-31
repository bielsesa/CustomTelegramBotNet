using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class ChatMember
    {
        private User user;
        private string status;
        private int untilDate;
        private bool canBeEdited;
        private bool canPostMessages;
        private bool canEditMessages;
        private bool canDeleteMessages;
        private bool canRestrictMembers;
        private bool canPromoteMembers;
        private bool canChangeInfo;
        private bool canInviteUsers;
        private bool canPinMessages;
        private bool isMember;
        private bool canSendMessages;
        private bool canSendMediaMessages;
        private bool canSendPolls;
        private bool canSendOtherMessages;
        private bool canAddWebPagePreviews;

        public User User { get; set; }
        public string Status { get; set; }
        public int UntilDate { get; set; }
        public bool CanBeEdited { get; set; }
        public bool CanPostMessages { get; set; }
        public bool CanEditMessages { get; set; }
        public bool CanDeleteMessages { get; set; }
        public bool CanRestrictMembers { get; set; }
        public bool CanPromoteMembers { get; set; }
        public bool CanChangeInfo { get; set; }
        public bool CanInviteUsers { get; set; }
        public bool CanPinMessages { get; set; }
        public bool IsMember { get; set; }
        public bool CanSendMessages { get; set; }
        public bool CanSendMediaMessages { get; set; }
        public bool CanSendPolls { get; set; }
        public bool CanSendOtherMessages { get; set; }
        public bool CanAddWebPagePreviews { get; set; }
    }
}
