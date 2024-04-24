using System.Diagnostics.CodeAnalysis;
using Microsoft.Bot.Schema;

namespace GarageGroup.Infra.Bot.Builder;

partial class TelegramTurnContextExtensions
{
    public static Activity BuildActivity([AllowNull] this TelegramParameters parameters)
        =>
        new(type: ActivityTypes.Message)
        {
            ChannelData = new TelegramChannelData(parameters).ToJObject()
        };
}