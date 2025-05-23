using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class SpaceCodexEntry : CodexEntry<SpaceFeature>
{
    public SpaceCodexEntry() : base(CodexEntryType.Space)
    {
    }
    
    public SpaceCodexEntry(SpaceFeature feature) : base(CodexEntryType.Space, feature)
    {
    }
}
