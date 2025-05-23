using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class GasGiantPlanetCodexEntry : CodexEntry<GasGiantPlanetType>
{
    // Codex entries without additional requirements should be initialized as NotExists
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.NotExists;

    public GasGiantPlanetCodexEntry() : base(CodexEntryType.GasGiantPlanet)
    {
    }

    public GasGiantPlanetCodexEntry(GasGiantPlanetType feature) : base(CodexEntryType.GasGiantPlanet, feature)
    {
    }
}
