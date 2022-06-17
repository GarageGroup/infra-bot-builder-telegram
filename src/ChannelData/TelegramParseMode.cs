using System.Runtime.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public enum TelegramParseMode
{
    [EnumMember(Value = "MarkdownV2")]
    MarkdownV2,

    [EnumMember(Value = "HTML")]
    Html
}