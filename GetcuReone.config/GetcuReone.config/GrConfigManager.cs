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
                    Load();

                return _current;
            }
        }
        private static GrConfiguration _current;

        /// <summary>
        /// Load <see cref="Current"/>.
        /// </summary>
        /// <param name="confiFile">Configuration file name.</param>
        public static void Load(string confiFile = GrConfigKeys.DefaultCofigFile)
        {
            var configuration = _Load(confiFile);
            _current = new GrConfiguration(configuration, confiFile);
        }

        /// <summary>
        /// Update <see cref="Current"/> configuration data.
        /// </summary>
        public static void Update()
        {
            if (_current == null)
                Load();
            else
                Load(_current.configFile);
        }

        /// <summary>
        /// Load <see cref="GetcuReoneConfig"/>.
        /// </summary>
        /// <param name="confiFile">Configuration file path.</param>
        internal static GetcuReoneConfig _Load(string confiFile)
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
