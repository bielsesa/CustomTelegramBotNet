namespace CustomTelegramBotNet.Types
{
    internal class Poll
    {
        private string id;
        private string question;
        private PollOption[] options;
        private bool isClosed;

        public string Id { get; set; }
        public string Question { get; set; }
        public PollOption[] Options { get; set; }
        public bool IsClosed { get; set; }
    }
}