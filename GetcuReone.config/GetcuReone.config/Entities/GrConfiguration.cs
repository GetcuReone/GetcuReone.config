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
        /// Sections.
        /// </summary>
        public GrSectionConfigCollection Sections { get; }

        internal GrConfiguration(GetcuReoneConfig getcuReoneConfig)
        {
            this.getcuReoneConfig = getcuReoneConfig;
            Sections = new GrSectionConfigCollection(getcuReoneConfig.Sections);
        }
    }
}
