using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
