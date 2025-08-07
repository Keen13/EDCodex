using EDCodex.Panel.Enums;
using System.Collections.Generic;
using System.Linq;

namespace EDCodex.Panel
{
    public static class PrefixService
    {
        /// <summary>
        /// Returns a list of formatted prefixes for the given sector name and mass indices.
        /// The mass indices are processed in reverse alphabetical order (from H to A).
        /// </summary>
        /// <param name="sectorName">The name of the sector to include in each prefix.</param>
        /// <param name="massIndices">The list of mass indices to process.</param>
        /// <returns>
        /// A <see cref="List{T}"/> of prefixes, where each one is formatted as:
        /// [&lt;Sector&gt; &lt;Cube&gt; &lt;MassIndex&gt;].
        /// </returns>
        public static List<string> GetAll(string sectorName, List<MassIndex> massIndices)
        {
            var prefixes = new List<string>();

            if (massIndices == null || !massIndices.Any())
            {
                return prefixes;
            }

            var massIndicesDescending = massIndices.OrderByDescending(mi => mi);

            foreach (var massIndex in massIndicesDescending)
            {
                var cubes = CubeService.GetForMassIndex(massIndex);
                if (cubes == null || !cubes.Any())
                {
                    continue;
                }

                foreach (var cube in cubes)
                {
                    prefixes.Add($"{sectorName} {cube} {massIndex}");
                }
            }

            return prefixes;
        }
    }
}
