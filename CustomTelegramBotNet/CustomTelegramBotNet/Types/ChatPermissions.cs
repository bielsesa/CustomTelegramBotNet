namespace CustomTelegramBotNet.Types
{
    internal class ChatPermissions
    {
        private bool canSendMessages;
        private bool canSendMediaMessages;
        private bool canSendPolls;
        private bool canSendOtherMessages;
        private bool canAddWebPagePreviews;
        private bool canChangeInfo;
        private bool canInviteUsers;
        private bool canPinMessages;

        public bool CanSendMessages { get; set; }
        public bool CanSendMediaMessages { get; set; }
        public bool CanSendPolls { get; set; }
        public bool CanSendOtherMessages { get; set; }
        public bool CanAddWebPagePreviews { get; set; }
        public bool CanChangeInfo { get; set; }
        public bool CanInviteUsers { get; set; }
        public bool CanPinMessages { get; set; }
    }
}