using GetcuReone.Cdm.Configuration;

namespace GetcuReone.Cdo.Configuration.Entities
{
    /// <summary>
    /// Configuration.
    /// </summary>
    public sealed class GrConfiguration
    {
        internal GetcuReoneConfig getcuReoneConfig;
        internal string configFile;

        /// <summary>
        /// Sections.
        /// </summary>
        public GrSectionConfigCollection Sections { get; }

        internal GrConfiguration(GetcuReoneConfig getcuReoneConfig, string configFile)
        {
            this.getcuReoneConfig = getcuReoneConfig;
            this.configFile = configFile;
            Sections = new GrSectionConfigCollection(getcuReoneConfig.Sections);
        }
    }
}
