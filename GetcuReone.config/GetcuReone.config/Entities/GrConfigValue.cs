using GetcuReone.Cdm.Configuration;

namespace GetcuReone.Cdo.Configuration.Entities
{
    /// <summary>
    /// Config value.
    /// </summary>
    public sealed class GrConfigValue
    {
        internal readonly ConfigValue _configValue;

        internal GrConfigValue(ConfigValue configValue)
        {
            _configValue = configValue;
        }

        /// <summary>
        /// Key.
        /// </summary>
        public string Key => _configValue.Key;

        /// <summary>
        /// Value.
        /// </summary>
        public string Value => _configValue.Value;
    }
}
