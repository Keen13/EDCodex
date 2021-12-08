using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public class SpaceCodexEntry : CodexEntry<SpaceFeature>
    {
        public SpaceCodexEntry() : base(CodexEntryType.Space)
        {
        }
        
        public SpaceCodexEntry(SpaceFeature feature) : base(CodexEntryType.Space, feature)
        {
        }
    }
}
