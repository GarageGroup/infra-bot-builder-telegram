using System;
using Newtonsoft.Json;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class TelegramInlineKeyboardMarkup : TelegramReplyMarkup
{
    public TelegramInlineKeyboardMarkup(TelegramInlineKeyboardButton[][] keyboard)
        =>
        Keyboard = keyboard ?? Array.Empty<TelegramInlineKeyboardButton[]>();

    [JsonProperty("inline_keyboard")]
    public TelegramInlineKeyboardButton[][] Keyboard { get; init; }
}