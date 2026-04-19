using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class GuardianCodexEntry : CodexEntry<GuardianObject>
{
    // Codex entries without additional requirements should be initialized as Absent
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.Absent;

    public GuardianCodexEntry() : base(CodexEntryType.Guardian)
    {
    }
    
    public GuardianCodexEntry(GuardianObject feature) : base(CodexEntryType.Guardian, feature)
    {
    }
}
