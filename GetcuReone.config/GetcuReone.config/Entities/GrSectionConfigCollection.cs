using GetcuReone.Cdm.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Configuration.Entities
{
    public sealed class GrSectionConfigCollection : IEnumerable<GrSectionConfig>
    {
        internal readonly List<SectionConfig> sectionConfigs;
        internal readonly List<GrSectionConfig> grSectionConfigs;

        /// <summary>
        /// Return configuration by key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public GrSectionConfig this[string key] => grSectionConfigs.Find(item => item.Name.Equals(key, StringComparison.OrdinalIgnoreCase));

        internal GrSectionConfigCollection(List<SectionConfig> sectionConfigs)
        {
            this.sectionConfigs = sectionConfigs;
            grSectionConfigs = sectionConfigs?.ConvertAll(config => new GrSectionConfig(config)) ?? new List<GrSectionConfig>();
        }

        /// <inheritdoc/>
        public IEnumerator<GrSectionConfig> GetEnumerator()
        {
            return grSectionConfigs.GetEnumerator();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return grSectionConfigs.GetEnumerator();
        }
    }
}
