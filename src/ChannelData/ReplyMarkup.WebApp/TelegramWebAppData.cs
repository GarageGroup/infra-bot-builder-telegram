using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramWebAppData
{
    [JsonProperty("data")]
    public string? Data { get; init; }
}