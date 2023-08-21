using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Parser.JsonConverters;

namespace King.AbpVnextPro.Paylink.Alipy.Parser
{
    public static class JsonParser
    {
#if NETSTANDARD2_1 || NET5_0_OR_GREATER
        public static readonly JsonSerializerOptions JsonSerializerOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, AllowTrailingCommas = true };
#else
        public static readonly JsonSerializerOptions JsonSerializerOptions = new() { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, AllowTrailingCommas = true };
#endif

        static JsonParser()
        {
            JsonSerializerOptions.Converters.Add(new NumberToStringConverter());
        }
    }
}
