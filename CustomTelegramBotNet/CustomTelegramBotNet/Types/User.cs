using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet
{
    class User
    {
        private int id;
        private bool isBot;
        private string firstName;
        private string secondName;
        private string username;
        private string languageCode;

        public int Id { get; set; }
        public bool IsBot { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Username { get; set; }
        public string LanguageCode { get; set; }
    }
}
