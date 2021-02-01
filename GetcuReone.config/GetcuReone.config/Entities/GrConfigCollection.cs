using GetcuReone.Cdm.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Configuration.Entities
{
    /// <summary>
    /// ConfigValue collection.
    /// </summary>
    public sealed class GrConfigCollection : IEnumerable<GrConfigValue>
    {
        internal readonly List<ConfigValue> configValues;
        internal readonly List<GrConfigValue> grConfigValues;

        /// <summary>
        /// Return configuration by key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public GrConfigValue this[string key] => grConfigValues.Find(item => item.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

        internal GrConfigCollection(List<ConfigValue> configValues)
        {
            this.configValues = configValues;
            grConfigValues = configValues?.ConvertAll(config => new GrConfigValue(config)) ?? new List<GrConfigValue>();
        }

        /// <inheritdoc/>
        public IEnumerator<GrConfigValue> GetEnumerator()
        {
            return grConfigValues.GetEnumerator();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return grConfigValues.GetEnumerator();
        }
    }
}
