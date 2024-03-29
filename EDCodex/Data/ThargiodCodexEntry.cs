﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public class ThargiodCodexEntry : CodexEntry<ThargoidObject>
    {
        // Codex entries without additional requirements should be initialized as NotExists
        protected override CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.NotExists;

        public ThargiodCodexEntry() : base(CodexEntryType.Thargiod)
        {
        }

        public ThargiodCodexEntry(ThargoidObject feature) : base(CodexEntryType.Thargiod, feature)
        {
        }
    }
}
