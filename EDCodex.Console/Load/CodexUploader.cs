using System;
using System.Collections.Generic;
using System.Linq;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;
using EDCodex.Data;

namespace ED_Codex.Load
{
    public static class CodexUploader
    {
        private static Codex Codex => DbAccessor.Codex; 
        
        /// <summary>
        /// The very first initialization of Codex data based on records from region 18.
        /// All missing entries must be added later with another method. 
        /// </summary>
        public static void InitCodex()
        {
            Codex.Stars = InitCodexEntries<StarCodexEntry, StarClass>();
            Codex.GasGiantPlanets = InitCodexEntries<GasGiantPlanetCodexEntry, GasGiantPlanetType>();
            Codex.TerrestrialPlanets = InitCodexEntries<TerrestrialPlanetCodexEntry, TerrestrialPlanetType>();
            Codex.GeoFeatures = InitCodexEntries<GeoCodexEntry, GeoFeature>();
            Codex.BioFeatures = InitCodexEntries<BioCodexEntry, BioFeature>();
            Codex.SpaceFeatures = InitCodexEntries<SpaceCodexEntry, SpaceFeature>();
            Codex.SpaceBioFeatures = InitCodexEntries<SpaceBioCodexEntry, SpaceBioFeature>();
            Codex.GuardianObjects = InitCodexEntries<GuardianCodexEntry, GuardianObject>();
            Codex.ThargoidObjects = InitCodexEntries<ThargiodCodexEntry, ThargoidObject>();
            DbAccessor.SaveCodex();
        }
        
        public static List<TEntry> InitCodexEntries<TEntry, TEntryType>()
            where TEntry : CodexEntry<TEntryType>, new()
            where TEntryType : Enum
        {
            var list = new List<TEntry>();
            foreach (TEntryType entryType in Enum.GetValues(typeof(TEntryType)))
            {
                var codexEntry = new TEntry { Feature = entryType };
                list.Add(codexEntry);
            }

            return list;
        }

        # region LoadData
        
        public static void LoadStarDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.Stars, galacticRegion);
            var data = StarsData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }
            
            foreach (var starCodexEntry in data)
            {
                var existingEntry = Codex.Stars.SingleOrDefault(entry => entry.Feature == starCodexEntry.Feature);
                if (existingEntry is null)
                {
                    starCodexEntry.InitializeStatusByGalacticRegion();
                    starCodexEntry.MarkAsExists(galacticRegion);
                    Codex.Stars.Add(starCodexEntry);
                }
                else
                {
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadGasGiantDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.GasGiantPlanets, galacticRegion);
            var data = GasGiantPlanetsData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var gasGiantCodexEntry in data)
            {
                var existingEntry = Codex.GasGiantPlanets.SingleOrDefault(entry => entry.Feature == gasGiantCodexEntry.Feature);
                if (existingEntry is null)
                {
                    gasGiantCodexEntry.InitializeStatusByGalacticRegion();
                    gasGiantCodexEntry.MarkAsExists(galacticRegion);
                    Codex.GasGiantPlanets.Add(gasGiantCodexEntry);
                }
                else
                {
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadTerrestrialDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.TerrestrialPlanets, galacticRegion);
            var data = TerrestrialPlanetsData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var terrestrialCodexEntry in data)
            {
                var existingEntry = Codex.TerrestrialPlanets.SingleOrDefault(entry => entry.Feature == terrestrialCodexEntry.Feature);
                if (existingEntry is null)
                {
                    terrestrialCodexEntry.InitializeStatusByGalacticRegion();
                    terrestrialCodexEntry.MarkAsExists(galacticRegion);
                    Codex.TerrestrialPlanets.Add(terrestrialCodexEntry);
                }
                else
                {
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadGeoDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.GeoFeatures, galacticRegion);
            var data = GeoFeaturesData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var terrestrialCodexEntry in data)
            {
                var existingEntry = Codex.GeoFeatures.SingleOrDefault(entry => entry.Feature == terrestrialCodexEntry.Feature);
                if (existingEntry is null)
                {
                    terrestrialCodexEntry.InitializeStatusByGalacticRegion();
                    terrestrialCodexEntry.MarkAsExists(galacticRegion);
                    Codex.GeoFeatures.Add(terrestrialCodexEntry);
                }
                else
                {
                    existingEntry.Requirements ??= terrestrialCodexEntry.Requirements; 
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadBioDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.BioFeatures, galacticRegion);
            var data = BioFeaturesData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var terrestrialCodexEntry in data)
            {
                var existingEntry = Codex.BioFeatures.SingleOrDefault(entry => entry.Feature == terrestrialCodexEntry.Feature);
                if (existingEntry is null)
                {
                    terrestrialCodexEntry.InitializeStatusByGalacticRegion();
                    terrestrialCodexEntry.MarkAsExists(galacticRegion);
                    Codex.BioFeatures.Add(terrestrialCodexEntry);
                }
                else
                {
                    existingEntry.Requirements ??= terrestrialCodexEntry.Requirements; 
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadSpaceDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.SpaceFeatures, galacticRegion);
            var data = SpaceFeaturesData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var terrestrialCodexEntry in data)
            {
                var existingEntry = Codex.SpaceFeatures.SingleOrDefault(entry => entry.Feature == terrestrialCodexEntry.Feature);
                if (existingEntry is null)
                {
                    terrestrialCodexEntry.InitializeStatusByGalacticRegion();
                    terrestrialCodexEntry.MarkAsExists(galacticRegion);
                    Codex.SpaceFeatures.Add(terrestrialCodexEntry);
                }
                else
                {
                    existingEntry.Requirements ??= terrestrialCodexEntry.Requirements; 
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadSpaceBioDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.SpaceBioFeatures, galacticRegion);
            var data = SpaceBioFeaturesData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var terrestrialCodexEntry in data)
            {
                var existingEntry = Codex.SpaceBioFeatures.SingleOrDefault(entry => entry.Feature == terrestrialCodexEntry.Feature);
                if (existingEntry is null)
                {
                    terrestrialCodexEntry.InitializeStatusByGalacticRegion();
                    terrestrialCodexEntry.MarkAsExists(galacticRegion);
                    Codex.SpaceBioFeatures.Add(terrestrialCodexEntry);
                }
                else
                {
                    existingEntry.Requirements ??= terrestrialCodexEntry.Requirements; 
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadThargoidDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.ThargoidObjects, galacticRegion);
            var data = ThargoidObjectsData.GetData(galacticRegion);
            SetMissingStatuses(data, galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var terrestrialCodexEntry in data)
            {
                var existingEntry = Codex.ThargoidObjects.SingleOrDefault(entry => entry.Feature == terrestrialCodexEntry.Feature);
                if (existingEntry is null)
                {
                    terrestrialCodexEntry.InitializeStatusByGalacticRegion();
                    terrestrialCodexEntry.MarkAsExists(galacticRegion);
                    Codex.ThargoidObjects.Add(terrestrialCodexEntry);
                }
                else
                {
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        public static void LoadGuardianDataForRegion(GalacticRegion galacticRegion)
        {
            SetMissingStatuses(Codex.GuardianObjects, galacticRegion);
            var data = GuardianObjectsData.GetData(galacticRegion);
            var areValid = ValidateDataForRequirements(data);
            if (!areValid)
            {
                Console.WriteLine("Codex will not be updated");
                return;
            }

            foreach (var terrestrialCodexEntry in data)
            {
                var existingEntry = Codex.GuardianObjects.SingleOrDefault(entry => entry.Feature == terrestrialCodexEntry.Feature);
                if (existingEntry is null)
                {
                    terrestrialCodexEntry.InitializeStatusByGalacticRegion();
                    terrestrialCodexEntry.MarkAsExists(galacticRegion);
                    Codex.GuardianObjects.Add(terrestrialCodexEntry);
                }
                else
                {
                    existingEntry.MarkAsExists(galacticRegion);
                }
            }
            
            DbAccessor.SaveCodex();
        }

        #endregion

        #region Data Validation

        private static void SetMissingStatuses<TCodexEntry>(List<TCodexEntry> data, GalacticRegion galacticRegion)
            where TCodexEntry : ICodexEntry
        {
            foreach (var codexEntry in data)
            {
                if (!codexEntry.StatusByGalacticRegion.ContainsKey(galacticRegion))
                {
                    codexEntry.StatusByGalacticRegion.Add(galacticRegion, CodexEntryStatus.Undefined);
                }
            }
        }   
        
        private static bool ValidateDataForRequirements(List<StarCodexEntry> data)
        {
            return true;
        }

        private static bool ValidateDataForRequirements(List<TerrestrialPlanetCodexEntry> data)
        {
            return true;
        }

        private static bool ValidateDataForRequirements(List<GasGiantPlanetCodexEntry> data)
        {
            return true;
        }
        
        private static bool ValidateDataForRequirements(List<GeoCodexEntry> data)
        {
            var isValid = true;
            foreach (var codexEntry in data)
            {
                var existingEntry = Codex.GeoFeatures.SingleOrDefault(entry => entry.Feature == codexEntry.Feature);
                if (existingEntry == null ||
                    existingEntry.StatusByGalacticRegion.Any(status => status.Value == CodexEntryStatus.Exists || status.Value == CodexEntryStatus.Found))
                {
                    if (codexEntry.Requirements == null)
                    {
                        isValid = false;
                        Console.WriteLine($"No requirements provided for {codexEntry.Feature.GetDescription()}");
                    }
                }
            }

            return true; // For the initial data, region 18
            return isValid;
        }

        private static bool ValidateDataForRequirements(List<BioCodexEntry> data)
        {
            var isValid = true;
            foreach (var codexEntry in data)
            {
                var existingEntry = Codex.BioFeatures.SingleOrDefault(entry => entry.Feature == codexEntry.Feature);
                if (existingEntry == null ||
                    existingEntry.StatusByGalacticRegion.Any(status => status.Value == CodexEntryStatus.Exists || status.Value == CodexEntryStatus.Found))
                {
                    if (codexEntry.Requirements == null)
                    {
                        isValid = false;
                        Console.WriteLine($"No requirements provided for {codexEntry.Feature.GetDescription()}");
                    }
                }
            }

            return true; // For the initial data, region 18
            return isValid;
        }

        private static bool ValidateDataForRequirements(List<SpaceCodexEntry> data)
        {
            var isValid = true;
            foreach (var codexEntry in data)
            {
                var existingEntry = Codex.SpaceFeatures.SingleOrDefault(entry => entry.Feature == codexEntry.Feature);
                if (existingEntry == null ||
                    existingEntry.StatusByGalacticRegion.Any(status => status.Value == CodexEntryStatus.Exists || status.Value == CodexEntryStatus.Found))
                {
                    if (codexEntry.Requirements == null)
                    {
                        isValid = false;
                        Console.WriteLine($"No requirements provided for {codexEntry.Feature.GetDescription()}");
                    }
                }
            }

            return true; // For the initial data, region 18
            return isValid;
        }

        private static bool ValidateDataForRequirements(List<SpaceBioCodexEntry> data)
        {
            var isValid = true;
            foreach (var codexEntry in data)
            {
                var existingEntry = Codex.SpaceBioFeatures.SingleOrDefault(entry => entry.Feature == codexEntry.Feature);
                if (existingEntry == null ||
                    existingEntry.StatusByGalacticRegion.Any(status => status.Value == CodexEntryStatus.Exists || status.Value == CodexEntryStatus.Found))
                {
                    if (codexEntry.Requirements == null)
                    {
                        isValid = false;
                        Console.WriteLine($"No requirements provided for {codexEntry.Feature.GetDescription()}");
                    }
                }
            }

            return true; // For the initial data, region 18
            return isValid;
        }

        private static bool ValidateDataForRequirements(List<ThargiodCodexEntry> data)
        {
            return true;
        }

        private static bool ValidateDataForRequirements(List<GuardianCodexEntry> data)
        {
            return true;
        }

        #endregion
    }
}
