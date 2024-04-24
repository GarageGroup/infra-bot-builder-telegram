using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramParameters
{
    internal static readonly TelegramParameters Default;

    static TelegramParameters()
        =>
        Default = new();

    private const string TelegramEmptyText = "ㅤ";

    public TelegramParameters([AllowNull] string text = TelegramEmptyText)
        =>
        Text = text.OrNullIfEmpty() ?? TelegramEmptyText;

    [JsonProperty("reply_markup")]
    public TelegramReplyMarkup? ReplyMarkup { get; init; }

    [JsonProperty("text")]
    public string Text { get; }

    [JsonProperty("parse_mode")]
    [JsonConverter(typeof(StringEnumConverter))]
    public TelegramParseMode? ParseMode { get; init; }

    [JsonProperty("disable_notification")]
    public bool DisableNotification { get; init; }
}