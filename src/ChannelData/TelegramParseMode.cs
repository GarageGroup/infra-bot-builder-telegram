using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace GGroupp.Infra.Bot.Builder;

[JsonConverter(typeof(StringEnumConverter))]
public enum TelegramParseMode
{
    [EnumMember(Value = "MarkdownV2")]
    MarkdownV2,

    [EnumMember(Value = "HTML")]
    Html
}