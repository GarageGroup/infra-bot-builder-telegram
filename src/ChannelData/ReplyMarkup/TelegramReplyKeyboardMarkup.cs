using System;
using Newtonsoft.Json;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class TelegramReplyKeyboardMarkup : TelegramReplyMarkup
{
    public TelegramReplyKeyboardMarkup(TelegramKeyboardButton[][] keyboard)
        =>
        Keyboard = keyboard ?? Array.Empty<TelegramKeyboardButton[]>();

    [JsonProperty("keyboard")]
    public TelegramKeyboardButton[][] Keyboard { get; }

    [JsonProperty("resize_keyboard")]
    public bool? ResizeKeyboard { get; init; }

    [JsonProperty("one_time_keyboard")]
    public bool? OneTimeKeyboard { get; init; }

    [JsonProperty("input_field_placeholder")]
    public string? InputFieldPlaceholder { get; init; }
}