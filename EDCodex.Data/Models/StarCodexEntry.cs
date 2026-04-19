using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class StarCodexEntry : CodexEntry<StarClass>
{
    // Codex entries without additional requirements should be initialized as Absent
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.Absent;
    
    public StarCodexEntry() : base(CodexEntryType.Star)
    {
    }

    public StarCodexEntry(StarClass feature) : base(CodexEntryType.Star, feature)
    {
    }
}
