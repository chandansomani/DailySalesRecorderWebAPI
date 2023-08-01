using System.Text.Json.Serialization;

namespace DailySalesRecorder.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InvoiceType
    {
        SEED = 0,
        PESTICIDE = 1,
        FERTILIZER =2
    }
}