using System;
using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramWebApp
{
    public TelegramWebApp(string url)
        =>
        Url = url.OrEmpty();
    
    [JsonProperty("url")]
    public string? Url { get; init; }
}
