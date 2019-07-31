using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class Update
    {
        private long updateId;
        private Message message;
        private Message editedMessage;
        private Message channelPost;
        private InlineQuery inlineQuery;
        private ChosenInlineResult chosenInlineResult;
        private CallbackQuery callbackQuery;
        private ShippingQuery shippingQuery;
        private PreCheckoutQuery preCheckoutQuery;
        private Poll poll;

        public long UpdateId { get; set; }
        public Message Message { get; set; }
        public Message EditedMessage { get; set; }
        public Message ChannelPost { get; set; }
        public InlineQuery InlineQuery { get; set; }
        public ChosenInlineResult ChosenInlineResult { get; set; }
        public CallbackQuery CallbackQuery { get; set; }
        public ShippingQuery ShippingQuery { get; set; }
        public PreCheckoutQuery PreCheckoutQuery { get; set; }
        public Poll Poll { get; set; }        
    }
}
