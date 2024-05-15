using RSC_HUMAD.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RSC_HUMAD.OutputTypes
{
    public class TypedPrincipal
    {
        public TypedPrincipal()
        {
        }

        public TypedPrincipal(string objectIdentifier, Label type)
        {
            ObjectIdentifier = objectIdentifier;
            ObjectType = type;
        }

        public string ObjectIdentifier { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Label ObjectType { get; set; }

    }
}