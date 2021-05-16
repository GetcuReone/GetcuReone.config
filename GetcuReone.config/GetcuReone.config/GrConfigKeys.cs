namespace GetcuReone.Cdo.Configuration
{
    /// <summary>
    /// Configuration keys.
    /// </summary>
    public static class GrConfigKeys
    {
        /// <summary>
        /// Default configuration file name.
        /// </summary>
        public const string DefaultCofigFile = "GetcuReone.config";

        /// <summary>
        /// Configuration keys for logging.
        /// </summary>
        public static class Logging
        {
            /// <summary>
            /// Name section.
            /// </summary>
            public const string Name = "logging";

            /// <summary>
            /// Logger name in nlog.
            /// </summary>
            public const string NlogLoggerName = "nlog.loggerName";
        }

        /// <summary>
        /// Configuration keys for settings.
        /// </summary>
        public static class Settings
        {
            /// <summary>
            /// Name section.
            /// </summary>
            public const string Name = "settings";

            /// <summary>
            /// Path to the settings folder.
            /// </summary>
            public const string SettingsFolder = "SettingsFolder";

            /// <summary>
            /// Settings file template.
            /// </summary>
            public const string TemplateSettingFile = "TemplateSettingFile";

            /// <summary>
            /// The path to the file with the types of settings.
            /// </summary>
            public const string SettingTypesFile = "SettingTypesFile";
        }
    }
}
