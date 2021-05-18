using System.Text.Json.Serialization;

namespace HappyTravel.Money.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Currencies
    {
        NotSpecified = 0,
        USD = 1,
        EUR = 2,
        AED = 3,
        SAR = 4,
        CNY = 5,
        GBP = 6,
        BHD = 7
    }
}