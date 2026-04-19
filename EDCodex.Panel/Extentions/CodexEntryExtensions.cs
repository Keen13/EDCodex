using EDCodex.Data.Enums;
using EDCodex.Data.Models;

namespace EDCodex.Panel.Extentions
{
    public static class CodexEntryExtensions
    {
        /// <summary>
        /// Returns the status of the codex entry for the current galactic region.
        /// If no status is found, returns <see cref="CodexEntryStatus.Undefined"/>.
        /// </summary>
        /// <param name="entry">The codex entry to retrieve the status for.</param>
        public static CodexEntryStatus GetStatusForRegion(this ICodexEntry entry, GalacticRegion region)
        {
            if (entry == null)
            {
                throw new System.ArgumentNullException(nameof(entry));
            }

            return entry.StatusByGalacticRegion.TryGetValue(region, out var status)
                ? status
                : CodexEntryStatus.Undefined;
        }
    }
}
