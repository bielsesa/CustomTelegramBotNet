using System;

namespace CustomTelegramBotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            TelegramBot botClient = new TelegramBot("paste-here-your-token");

            botClient.StartReceiving();

            Console.WriteLine("Bot connected! Press any key to stop the bot.");
            Console.ReadLine();
        }
    }
}
