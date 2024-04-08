using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramKeyboardButton
{
    public TelegramKeyboardButton(string text)
        =>
        Text = text ?? string.Empty;

    [JsonProperty("text")]
    public string Text { get; }

    [JsonProperty("web_app")]
    public TelegramWebApp? WebApp { get; init; }
}