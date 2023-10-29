using System.Text.Json.Serialization;

namespace tutorial.Models{
public enum RpgClass
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    Knight=1,
    Mage=2,
    Cleric =3
}

}
