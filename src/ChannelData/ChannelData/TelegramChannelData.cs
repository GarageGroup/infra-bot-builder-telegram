using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramChannelData
{
    private static readonly JsonSerializer Serializer;

    static TelegramChannelData()
        =>
        Serializer = JsonSerializer.Create(new()
        {
            NullValueHandling = NullValueHandling.Ignore
        });

    public TelegramChannelData([AllowNull] TelegramParameters parameters)
        =>
        Parameters = parameters ?? TelegramParameters.Default;

    [JsonProperty("method")]
    public string Method { get; } = "sendMessage";

    [JsonProperty("parameters")]
    public TelegramParameters Parameters { get; }

    public JObject ToJObject()
        =>
        JObject.FromObject(this, Serializer);
}