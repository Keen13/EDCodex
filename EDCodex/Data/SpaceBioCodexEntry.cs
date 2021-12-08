using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public class SpaceBioCodexEntry : CodexEntry<SpaceBioFeature>
    {
        public SpaceBioCodexEntry() : base(CodexEntryType.SpaceBio)
        {
        }

        public SpaceBioCodexEntry(SpaceBioFeature feature) : base(CodexEntryType.SpaceBio, feature)
        {
        }
    }
}
