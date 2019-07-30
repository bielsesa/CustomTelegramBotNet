using System;
using System.Threading;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
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
        private static string _updateRequest = "";
        private static string _lastUpdateId = "";
        private static JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
        private static JToken jtLastMessage;
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
                System.IO.File.WriteAllText(
                    @"C:\Users\step\source\repos\CustomTelegramBotNet\CustomTelegramBotNet\CustomTelegramBotNet", 
                    string.Format("[{0}] Before GetStringAsync", DateTime.Now.ToString("HH:mm:ss")));

                _updateRequest = await _client.GetStringAsync(uriBaseWithToken + "getUpdates");

                System.IO.File.WriteAllText(
                    @"C:\Users\step\source\repos\CustomTelegramBotNet\CustomTelegramBotNet\CustomTelegramBotNet",
                    string.Format("[{0}] Update Request: {1}", DateTime.Now.ToString("HH:mm:ss"), _updateRequest));

                System.IO.File.WriteAllText(
                    @"C:\Users\step\source\repos\CustomTelegramBotNet\CustomTelegramBotNet\CustomTelegramBotNet",
                    string.Format("[{0}] After GetStringAsync", DateTime.Now.ToString("HH:mm:ss")));

                dynamic jsonObject = JsonConvert.DeserializeObject(_updateRequest);

                if (jsonObject["ok"] == "true")
                {
                    JArray jResultArray = JsonConvert.DeserializeObject<JArray>(jsonObject["result"].ToString());
                    if (jResultArray.Last().ToString() != _lastUpdateId)
                    {
                        foreach (var jArrayItem in jResultArray)
                        {
                            Console.WriteLine(jArrayItem);
                            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                        }

                        jtLastMessage = jResultArray.Last();
                        _lastUpdateId = jResultArray.Last().ToString();
                        SendTextMessageAsync("Hello World!", 215335718);
                    }
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

        private static void ParseJsonResponse(string text)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject(text);

            if (jsonObject["ok"] == "true")
            {
                JArray jResultArray = JsonConvert.DeserializeObject<JArray>(jsonObject["result"].ToString());
                if (jResultArray.Last().ToString() != _lastUpdateId)
                {
                    foreach (var jArrayItem in jResultArray)
                    {
                        Console.WriteLine(jArrayItem);
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    }

                    jtLastMessage = jResultArray.Last();
                    _lastUpdateId = jResultArray.Last().ToString();
                    SendTextMessageAsync("Hello World!", 215335718);
                }
            }
        }
    }
}
