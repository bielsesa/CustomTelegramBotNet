using System;
using System.Threading;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using CustomTelegramBotNet.Types;
using System.Collections.Generic;

namespace CustomTelegramBotNet
{
    class TelegramBot
    {
        #region Attributes and Properties
        private string token;
        public string Token { get; set; }

        private static string uriBaseWithToken;

        private static CancellationTokenSource _receivingCancellationTokenSource;
        private static readonly HttpClient _client = new HttpClient();
        private static string _lastUpdateId = "0";
        private static JsonSerializer _jsonSerializer = JsonSerializer.CreateDefault();
        private static JToken _lastMessage;
        #endregion

        #region Constructors
        public TelegramBot() { }

        public TelegramBot(string token)
        {
            this.token = token;
            uriBaseWithToken = string.Format("https://api.telegram.org/bot{0}/", token);
        }
        #endregion

        #region Receiving Methods
        public void StartReceiving(CancellationToken cancellationToken = default)
        {
            _receivingCancellationTokenSource = new CancellationTokenSource();

            cancellationToken.Register(() => _receivingCancellationTokenSource.Cancel());

            ReceiveAsync(_receivingCancellationTokenSource.Token);
        }

        private static async void ReceiveAsync(CancellationToken cancellationToken = default)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await _client.GetAsync(string.Format("{0}getUpdates?offset={1}", uriBaseWithToken, _lastUpdateId), cancellationToken);

                    dynamic jsonObject = JsonConvert.DeserializeObject(await httpResponseMessage.Content.ReadAsStringAsync());

                    if (jsonObject["ok"] == "true")
                    {
                        JArray jResultArray = JsonConvert.DeserializeObject<JArray>(jsonObject["result"].ToString());
                        if (jResultArray.Last()["update_id"].ToString() != _lastUpdateId)
                        {
                            foreach (var jArrayItem in jResultArray)
                            {
                                Console.WriteLine(jArrayItem);
                                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                            }

                            _lastMessage = jResultArray.Last()["message"];
                            _lastUpdateId = jResultArray.Last()["update_id"].ToString();
                        }
                    }
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Error en el request HTTP.");
                }
            }
        }
        #endregion

        #region Message Methods
        private static async void SendTextMessageAsync(string text, long chatId)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("{0}sendMessage?chat_id={1}&text={2}", uriBaseWithToken, chatId, text));

            HttpResponseMessage messageSentResponse = await _client.SendAsync(message);

            string response = await messageSentResponse.Content.ReadAsStringAsync();

            Console.WriteLine(response);
        }
        #endregion
    }
}
