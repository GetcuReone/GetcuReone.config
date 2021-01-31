using GetcuReone.Cdm.Configuration;

namespace GetcuReone.Cdo.Configuration.Entities
{
    /// <summary>
    /// Configuration.
    /// </summary>
    public sealed class GrConfiguration
    {
        internal GetcuReoneConfig getcuReoneConfig;

        /// <summary>
        /// Settings configuration.
        /// </summary>
        public GrConfigCollection Settings { get; }

        /// <summary>
        /// Logging configuration.
        /// </summary>
        public GrConfigCollection Logging { get; }

        internal GrConfiguration(GetcuReoneConfig getcuReoneConfig)
        {
            this.getcuReoneConfig = getcuReoneConfig;
            Settings = new GrConfigCollection(getcuReoneConfig.SettingsConfigs);
            Logging = new GrConfigCollection(getcuReoneConfig.LoggingConfigs);
        }
    }
}
