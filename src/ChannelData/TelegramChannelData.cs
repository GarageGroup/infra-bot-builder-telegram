using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramChannelData
{
    private static readonly JsonSerializer jsonSerializer;

    static TelegramChannelData()
    {
        jsonSerializer = JsonSerializer.Create(new()
        {
            NullValueHandling = NullValueHandling.Ignore
        });
    }

    public TelegramChannelData(TelegramParameters parameters)
        =>
        Parameters = parameters ?? new();

    [JsonProperty("method")]
    public string Method { get; } = "sendMessage";

    [JsonProperty("parameters")]
    public TelegramParameters Parameters { get; }

    public JObject ToJObject()
        =>
        JObject.FromObject(this, jsonSerializer);
}