using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramInlineKeyboardButton
{
    public TelegramInlineKeyboardButton(string text)
        =>
        Text = text ?? string.Empty;

    [JsonProperty("text")]
    public string Text { get; }

    [JsonProperty("url")]
    public string? Url { get; init; }

    [JsonProperty("callback_data")]
    public string? CallbackData { get; init; }
}