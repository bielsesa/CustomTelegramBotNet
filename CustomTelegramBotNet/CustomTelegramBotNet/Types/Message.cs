using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CustomTelegramBotNet.Types
{
    class Message
    {
        private int messageId;
        User from;
        int date;
        Chat chat;
        User forwardFrom;
        Chat forwardFromChat;
        int forwardFromMessageId;
        string forwardSignature;
        string forwardSenderName;
        int forwardDate;
        Message replyToMessage;
        int editDate;
        string mediaGroupId;
        string authorSignature;
        string text;
        MessageEntity[] entities;
        MessageEntity[] captionEntities;
        Audio audio;
        Document document;
        Animation animation;
        Game game;
        PhotoSize[] photo;
        Sticker sticker;
        Video video;
        Voice voice;
        VideoNote videoNote;
        string caption;
        Contact contact;
        Location location;
        Venue venue;
        Poll poll;
        User[] newChatMembers;
        User leftChatMember;
        string newChatTitle;
        PhotoSize[] newChatPhoto;

        public void DeserializeFromJson (JToken jToken)
        {

        }
    }
}
