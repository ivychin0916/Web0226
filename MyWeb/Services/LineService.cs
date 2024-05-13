using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;

        if (message.Contains("抽籤"))
        {
            //creat a pool for image
            string[] imageUrl = new string[]
            {
                "https://i.imgur.com/pQSopio.png", //大凶
                "https://i.imgur.com/352dYTW.png", //大吉
                "https://i.imgur.com/vofyUaW.png", //小吉
                "https://i.imgur.com/vofyUaW.png", //小吉
                "https://i.imgur.com/uvFnBWr.png", //中吉
                "https://i.imgur.com/uvFnBWr.png", //中吉
                "https://i.imgur.com/e4HcD7U.png", //凶
                "https://i.imgur.com/lVrr8se.png", //平
                "https://i.imgur.com/lVrr8se.png", //平
                "https://i.imgur.com/lVrr8se.png", //平
                "https://i.imgur.com/y5CWKp3.png", //吉
                "https://i.imgur.com/y5CWKp3.png", //吉
                "https://i.imgur.com/y5CWKp3.png", //吉
            };
            
            //get a random number for index
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imageUrl.Length);
            
            //return a random image with random number,
            return new List<ISendMessage>
            {
                new ImageMessage(imageUrl[index], imageUrl[index], null)
            };
        }

        result = new List<ISendMessage>
        {
            new TextMessage($"聽不懂喔@@")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,
        string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,
        string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,
        string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,
        string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,
        string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}