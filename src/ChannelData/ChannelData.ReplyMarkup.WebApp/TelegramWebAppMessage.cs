using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramWebAppMessage
{
    [JsonProperty("web_app_data")]
    public TelegramWebAppData? WebAppData { get; init; }
}