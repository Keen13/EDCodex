using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public class CodexEntry<T> where T : Enum
    {
        public CodexEntry(T feature)
        {
            Feature = feature;
            InitializeStatusByGalacticRegion();
        }

        public CodexEntry(CodexEntryType type, T feature)
        {
            InitializeStatusByGalacticRegion();
            Feature = feature;
            Type = type;
        }

        public string Descripion => Feature.GetDescription();

        public CodexEntryType Type { get; set; }

        public T Feature { get; set; }

        public Requirements Requirements { get; set; } 

        public Dictionary<GalacticRegion, CodexEntryStatus> StatusByGalacticRegion { get; } = new Dictionary<GalacticRegion, CodexEntryStatus>();

        public void MarkAsFound(GalacticRegion galacticRegion)
        {
            StatusByGalacticRegion[galacticRegion] = CodexEntryStatus.Found;
        }

        public void MarkAsNotExists(GalacticRegion galacticRegion)
        {
            StatusByGalacticRegion[galacticRegion] = CodexEntryStatus.NotExists;
        }

        private void InitializeStatusByGalacticRegion()
        {
            foreach (GalacticRegion galacticRegion in Enum.GetValues(typeof(GalacticRegion)))
            {
                StatusByGalacticRegion.Add(galacticRegion, CodexEntryStatus.Exists);
            }
        }
    }
}
