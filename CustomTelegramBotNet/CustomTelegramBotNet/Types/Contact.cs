namespace CustomTelegramBotNet.Types
{
    internal class Contact
    {
        private string phoneNumber;
        private string firstName;
        private string lastName;
        private int userId;
        private string vcard;

        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public string Vcard { get; set; }
    }
}