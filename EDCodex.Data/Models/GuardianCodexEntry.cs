using EDCodex.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDCodex.Data.Models;

public class GuardianCodexEntry : CodexEntry<GuardianObject>
{
    // Codex entries without additional requirements should be initialized as NotExists
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.NotExists;

    public GuardianCodexEntry() : base(CodexEntryType.Guardian)
    {
    }
    
    public GuardianCodexEntry(GuardianObject feature) : base(CodexEntryType.Guardian, feature)
    {
    }
}
