using EDCodex.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDCodex.Data.Models;

public class TerrestrialPlanetCodexEntry : CodexEntry<TerrestrialPlanetType>
{
    // Codex entries without additional requirements should be initialized as NotExists
    protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.NotExists;

    public TerrestrialPlanetCodexEntry() : base(CodexEntryType.TerrestrialPlanet)
    {
    }
    
    public TerrestrialPlanetCodexEntry(TerrestrialPlanetType feature) : base(CodexEntryType.TerrestrialPlanet, feature)
    {
    }
}
