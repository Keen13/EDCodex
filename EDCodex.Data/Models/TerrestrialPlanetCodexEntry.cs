using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class TerrestrialPlanetCodexEntry : CodexEntry<TerrestrialPlanetType>
{
    // Codex entries without additional requirements should be initialized as Absent
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.Absent;

    public TerrestrialPlanetCodexEntry() : base(CodexEntryType.TerrestrialPlanet)
    {
    }
    
    public TerrestrialPlanetCodexEntry(TerrestrialPlanetType feature) : base(CodexEntryType.TerrestrialPlanet, feature)
    {
    }
}
