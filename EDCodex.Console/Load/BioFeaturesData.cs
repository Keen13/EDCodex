﻿using System;
using System.Collections.Generic;
using EDCodex.Data.Enums;
using EDCodex.Data.Models;

namespace ED_Codex.Load;

public class BioFeaturesData
{
    public static List<BioCodexEntry> GetData(GalacticRegion galacticRegion)
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
    public static List<BioCodexEntry> Data18 =>
        [
            new BioCodexEntry(BioFeature.CommonThargoidBarnacle)
            {
                Requirements = new Requirements
                {
                    Location = Location.Nebula,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.HMC,
                        TerrestrialPlanetType.R,
                        TerrestrialPlanetType.MR
                    }
                }
            },
            new BioCodexEntry(BioFeature.LargeThargoidBarnacle)
            {
                Requirements = new Requirements
                {
                    Location = Location.Nebula,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.HMC,
                        TerrestrialPlanetType.R,
                        TerrestrialPlanetType.MR
                    }
                }
            },
            new BioCodexEntry(BioFeature.ThargoidBarnacleBarbs)
            {
                Requirements = new Requirements
                {
                    Location = Location.Nebula,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.HMC,
                        TerrestrialPlanetType.R,
                        TerrestrialPlanetType.MR
                    }
                }
            },
            new BioCodexEntry(BioFeature.RoseumBrainTree)
            {
                Requirements = new Requirements
                {
                    TemperatureRange = "200-500 K",
                    AnyVolcanism = true,
                }
            },
            new BioCodexEntry(BioFeature.GypseeumBrainTree)
            {
                Requirements = new Requirements
                {
                    TemperatureRange = "200-300 K",
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.R,
                    },
                    PlanetsInSystem = 
                    {
                        TerrestrialPlanetType.E,
                    },
                    GasGiantsInSystem = 
                    {
                        GasGiantPlanetType.GWL,
                        GasGiantPlanetType.WG,
                    }
                }
            },
            new BioCodexEntry(BioFeature.OstrinumBrainTree)
            {
                Requirements = new Requirements
                {
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.HMC,
                        TerrestrialPlanetType.MR,
                    },
                    PlanetsInSystem = 
                    {
                        TerrestrialPlanetType.E,
                    },
                    GasGiantsInSystem = 
                    {
                        GasGiantPlanetType.GWL,
                        GasGiantPlanetType.WG,
                    }
                }
            },
            new BioCodexEntry(BioFeature.VirideBrainTree)
            {
                Requirements = new Requirements
                {
                    TemperatureRange = "100-270 K",
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.RI,
                    },
                    PlanetsInSystem = 
                    {
                        TerrestrialPlanetType.E,
                    },
                    GasGiantsInSystem = 
                    {
                        GasGiantPlanetType.GWL,
                        GasGiantPlanetType.WG,
                    }
                }
            },
            new BioCodexEntry(BioFeature.LividumBrainTree)
            {
                Requirements = new Requirements
                {
                    TemperatureRange = "300-500 K",
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.R,
                    },
                    PlanetsInSystem = 
                    {
                        TerrestrialPlanetType.E,
                    },
                    GasGiantsInSystem = 
                    {
                        GasGiantPlanetType.GWL,
                        GasGiantPlanetType.WG,
                    }
                }
            },
            new BioCodexEntry(BioFeature.AureumBrainTree)
            {
                Requirements = new Requirements
                {
                    TemperatureRange = "300-500 K",
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.HMC,
                        TerrestrialPlanetType.MR,
                    },
                    PlanetsInSystem = 
                    {
                        TerrestrialPlanetType.E,
                    },
                    GasGiantsInSystem = 
                    {
                        GasGiantPlanetType.GWL,
                        GasGiantPlanetType.WG,
                    }
                }
            },
            new BioCodexEntry(BioFeature.LindigoticumBrainTree)
            {
                Requirements = new Requirements
                {
                    TemperatureRange = "300-500 K",
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.HMC,
                        TerrestrialPlanetType.R,
                    },
                    PlanetsInSystem = 
                    {
                        TerrestrialPlanetType.E,
                    },
                    GasGiantsInSystem = 
                    {
                        GasGiantPlanetType.GWL,
                        GasGiantPlanetType.WG,
                    }
                }
            },
            new BioCodexEntry(BioFeature.BarkMound)
            {
                Requirements = new Requirements
                {
                    Location = Location.Nebula
                }
            },
            new BioCodexEntry(BioFeature.LuteolumAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.B },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.R,
                    }
                }
            },
            new BioCodexEntry(BioFeature.CroceumAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.A, StarClass.B },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.R,
                    }
                }
            },
            new BioCodexEntry(BioFeature.PunicelumAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.O },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.I,
                        TerrestrialPlanetType.RI,
                    }
                }
            },
            new BioCodexEntry(BioFeature.RoseumAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.B },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.R,
                    }
                }
            },
            new BioCodexEntry(BioFeature.BlatteumBioluminescentAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.B },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.MR,
                        TerrestrialPlanetType.HMC,
                    }
                }
            },
            new BioCodexEntry(BioFeature.RubeumBioluminescentAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.A, StarClass.B },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.MR,
                        TerrestrialPlanetType.HMC,
                    }
                }
            },
            new BioCodexEntry(BioFeature.PrasinumBioluminescentAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.O },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.MR,
                        TerrestrialPlanetType.HMC,
                        TerrestrialPlanetType.R
                    }
                }
            },
            new BioCodexEntry(BioFeature.RoseumBioluminescentAnemone)
            {
                Requirements = new Requirements
                {
                    FoundAtStars = { StarClass.B },
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.MR,
                        TerrestrialPlanetType.HMC
                    }
                }
            },
            new BioCodexEntry(BioFeature.RoseumSinuousTubers)
            {
                Requirements = new Requirements
                {
                    FoundWithVolcanism = { Volcanism.SilicateMagma }
                }
            },
            new BioCodexEntry(BioFeature.BlatteumSinuousTubers)
            {
                Requirements = new Requirements
                {
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.MR,
                        TerrestrialPlanetType.HMC
                    }
                }
            },
            new BioCodexEntry(BioFeature.LindigoticumSinuousTubers)
            {
                Requirements = new Requirements
                {
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.R
                    }
                }
            },
            new BioCodexEntry(BioFeature.ViolaceumSinuousTubers)
            {
                Requirements = new Requirements
                {
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.MR,
                        TerrestrialPlanetType.HMC
                    }
                }
            },
            new BioCodexEntry(BioFeature.VirideSinuousTubers)
            {
                Requirements = new Requirements
                {
                    AnyVolcanism = true,
                    FoundOnPlanets =
                    {
                        TerrestrialPlanetType.R,
                        TerrestrialPlanetType.HMC
                    }
                }
            },
      ];
}