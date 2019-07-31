namespace CustomTelegramBotNet.Types
{
    internal class KeyboardButton
    {
        private string text;
        private bool requestContact;
        private bool requestLocation;

        public string Text { get; set; }
        public bool RequestContact { get; set; }
        public bool RequestLocation { get; set; }
    }
}