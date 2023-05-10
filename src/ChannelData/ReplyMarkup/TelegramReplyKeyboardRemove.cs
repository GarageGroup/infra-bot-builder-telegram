using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramReplyKeyboardRemove : TelegramReplyMarkup
{
    [JsonProperty("remove_keyboard")]
    public bool RemoveKeyboard { get; } = true;
}