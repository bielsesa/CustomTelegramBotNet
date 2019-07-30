using System;

namespace CustomTelegramBotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            TelegramBot botClient = new TelegramBot("953705394:AAFtLctlHehkU9qdI06-QLYPr-cGHel0tQY");

            botClient.StartReceiving();

            Console.WriteLine("Bot conectado. Pulse cualquier tecla para cerrar el programa.");
            Console.ReadLine();
        }
    }
}
