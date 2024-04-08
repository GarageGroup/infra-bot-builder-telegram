using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GarageGroup.Infra.Bot.Builder;

public readonly record struct TelegramWebAppResponse
{
    public static TelegramWebAppResponse FromChannelData(object? channelData)
    {
        if (channelData is not JObject jData)
        {
            return default;
        }

        return jData.ToObject<TelegramWebAppResponse>();
    }

    [JsonProperty("message")]
    public TelegramWebAppMessage? Message { get; init; }
}
