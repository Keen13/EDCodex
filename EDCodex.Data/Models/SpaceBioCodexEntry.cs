using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class SpaceBioCodexEntry : CodexEntry<SpaceBioFeature>
{
    public SpaceBioCodexEntry() : base(CodexEntryType.SpaceBio)
    {
    }

    public SpaceBioCodexEntry(SpaceBioFeature feature) : base(CodexEntryType.SpaceBio, feature)
    {
    }
}
