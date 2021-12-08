using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public class BioCodexEntry : CodexEntry<BioFeature>
    {
        public BioCodexEntry() : base(CodexEntryType.Bio)
        {
        }

        public BioCodexEntry(BioFeature feature) : base(CodexEntryType.Bio, feature)
        {
        }
    }
}
