using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDCodex.Data.Enums;

namespace EDCodex.Data.Models
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
