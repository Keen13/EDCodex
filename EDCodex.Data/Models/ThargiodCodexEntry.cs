using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class ThargiodCodexEntry : CodexEntry<ThargoidObject>
{
    // Codex entries without additional requirements should be initialized as NotExists
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.NotExists;

    public ThargiodCodexEntry() : base(CodexEntryType.Thargiod)
    {
    }

    public ThargiodCodexEntry(ThargoidObject feature) : base(CodexEntryType.Thargiod, feature)
    {
    }
}
