using GetcuReone.Cdm.Configuration;
using GetcuReone.Cdo.Configuration.Entities;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GetcuReone.Cdo.Configuration
{
    /// <summary>
    /// Config manager.
    /// </summary>
    public static class GrConfigManager
    {
        /// <summary>
        /// Current configuration.
        /// </summary>
        public static GrConfiguration Current
        {
            get
            {
                if (_current == null)
                    _current = new GrConfiguration(Load("GetcuReone.config"));
                    
                return _current;
            }
        }
        private static GrConfiguration _current;

        /// <summary>
        /// Load <see cref="GetcuReoneConfig"/>.
        /// </summary>
        /// <param name="confiFile">Configuration file path.</param>
        internal static GetcuReoneConfig Load(string confiFile)
        {
            if (!File.Exists(confiFile))
                return new GetcuReoneConfig
                {
                    Sections = new List<SectionConfig>(),
                };
                
            using (var fileStream = File.OpenRead(confiFile))
            {
                var formatter = new XmlSerializer(typeof(GetcuReoneConfig), new XmlRootAttribute("configuration"));
                return (GetcuReoneConfig)formatter.Deserialize(fileStream);
            }
        }
    }
}
