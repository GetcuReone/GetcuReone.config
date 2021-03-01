using GetcuReone.Cdm.Configuration;

namespace GetcuReone.Cdo.Configuration.Entities
{
    /// <summary>
    /// Section config.
    /// </summary>
    public sealed class GrSectionConfig
    {
        internal readonly SectionConfig _sectionConfig;

        internal GrSectionConfig(SectionConfig sectionConfig)
        {
            _sectionConfig = sectionConfig;
            Configs = new GrConfigCollection(sectionConfig.Configs);
        }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name => _sectionConfig.Name;

        /// <summary>
        /// Config collection.
        /// </summary>
        public GrConfigCollection Configs { get; }
    }
}
