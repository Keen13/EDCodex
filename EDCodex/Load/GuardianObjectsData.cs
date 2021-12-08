using System;
using System.Collections.Generic;
using ED_Codex.Data;
using ED_Codex.Enums;

namespace ED_Codex.Load
{
    public class GuardianObjectsData
    {
        public static List<GuardianCodexEntry> GetData(GalacticRegion galacticRegion)
        {
            return 
                (int) galacticRegion switch
                {
                    // 1 => Data01,
                    // 2 => Data02,
                    // 3 => Data03,
                    // 4 => Data04,
                    // 5 => Data05,
                    // 6 => Data06,
                    // 7 => Data07,
                    // 8 => Data08,
                    // 9 => Data09,
                    // 10 => Data10,
                    // 11 => Data11,
                    // 12 => Data12,
                    // 13 => Data13,
                    // 14 => Data14,
                    // 15 => Data15,
                    // 16 => Data16,
                    // 17 => Data17,
                    18 => Data18,
                    // 19 => Data19,
                    // 20 => Data20,
                    // 21 => Data21,
                    // 22 => Data22,
                    // 23 => Data23,
                    // 24 => Data24,
                    // 25 => Data25,
                    // 26 => Data26,
                    // 27 => Data27,
                    // 28 => Data28,
                    // 29 => Data29,
                    // 30 => Data30,
                    // 31 => Data31,
                    // 32 => Data32,
                    // 33 => Data33,
                    // 34 => Data34,
                    // 35 => Data35,
                    // 36 => Data36,
                    // 37 => Data37,
                    // 38 => Data38,
                    // 39 => Data39,
                    // 40 => Data40,
                    // 41 => Data14,
                    // 42 => Data42,
                    _ => throw new ArgumentException()
                };
        }

        // List only existing Terrestrials types for a region. Other will be marked as NotExists by default
        // Use Data18 as template
        public static List<GuardianCodexEntry> Data18 =>
            new List<GuardianCodexEntry>
            {
                new GuardianCodexEntry(GuardianObject.GuardianCodex)
                {
                },
                new GuardianCodexEntry(GuardianObject.GuardianDataTerminal)
                {
                },
                new GuardianCodexEntry(GuardianObject.GuardianPylon)
                {
                },
                new GuardianCodexEntry(GuardianObject.GuardianRelicTower)
                {
                },
                new GuardianCodexEntry(GuardianObject.GuardianSentinel)
                {
                },
                new GuardianCodexEntry(GuardianObject.GuardianBeacon)
                {
                },
         };
    }
}