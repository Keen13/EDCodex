using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public class StarCodexEntry : CodexEntry<StarClass>
    {
        // Codex entries without additional requirements should be initialized as NotExists
        protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.NotExists;
        
        public StarCodexEntry() : base(CodexEntryType.Star)
        {
        }

        public StarCodexEntry(StarClass feature) : base(CodexEntryType.Star, feature)
        {
        }
    }
}
