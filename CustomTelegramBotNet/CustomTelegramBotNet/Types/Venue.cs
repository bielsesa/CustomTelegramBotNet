namespace CustomTelegramBotNet.Types
{
    internal class Venue
    {
        private Location location;
        private string title;
        private string address;
        private string foursquareId;
        private string foursquareType;

        public Location Location { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string FoursquareId { get; set; }
        public string FoursquareType { get; set; }
    }
}