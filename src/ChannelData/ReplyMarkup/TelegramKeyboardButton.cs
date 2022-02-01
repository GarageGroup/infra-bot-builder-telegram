using Newtonsoft.Json;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class TelegramKeyboardButton
{
    public TelegramKeyboardButton(string text)
        =>
        Text = text ?? string.Empty;

    [JsonProperty("text")]
    public string Text { get; }
}