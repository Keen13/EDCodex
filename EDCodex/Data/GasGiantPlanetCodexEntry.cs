using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_Codex.Enums;

namespace ED_Codex.Data
{
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
}
