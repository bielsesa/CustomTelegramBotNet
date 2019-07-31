using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CustomTelegramBotNet
{
    class GlobalData
    {
        private static string userDbFilename = "users.db";
        public static string UserDbFilename { get { return userDbFilename; } set { userDbFilename = value; } }
        public static string BuildDir { get; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}
