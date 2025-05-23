using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class GeoCodexEntry : CodexEntry<GeoFeature>
{
    public GeoCodexEntry() : base(CodexEntryType.Geo)
    {
    }

    public GeoCodexEntry(GeoFeature feature) : base(CodexEntryType.Geo, feature)
    {
    }
}
