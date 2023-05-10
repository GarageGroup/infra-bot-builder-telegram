using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramParameters
{
    public TelegramParameters(string? text = default)
        =>
        Text = text;

    [JsonProperty("reply_markup")]
    public TelegramReplyMarkup? ReplyMarkup { get; init; }

    [JsonProperty("text")]
    public string? Text { get; }

    [JsonProperty("parse_mode")]
    [JsonConverter(typeof(StringEnumConverter))]
    public TelegramParseMode? ParseMode { get; init; }

    [JsonProperty("disable_notification")]
    public bool DisableNotification { get; init; }
}