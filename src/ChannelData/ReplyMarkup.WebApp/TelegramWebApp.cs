using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramWebApp
{
    public TelegramWebApp(string url)
        =>
        Url = url ?? string.Empty;
    
    [JsonProperty("url")]
    public string? Url { get; init; }
}
