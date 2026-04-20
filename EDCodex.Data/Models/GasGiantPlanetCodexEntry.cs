using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class GasGiantPlanetCodexEntry : CodexEntry<GasGiantPlanetType>
{
    // Codex entries without additional requirements should be initialized as Absent
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.Absent;

    public GasGiantPlanetCodexEntry() : base(CodexEntryType.GasGiantPlanet)
    {
    }

    public GasGiantPlanetCodexEntry(GasGiantPlanetType feature) : base(CodexEntryType.GasGiantPlanet, feature)
    {
    }
}
