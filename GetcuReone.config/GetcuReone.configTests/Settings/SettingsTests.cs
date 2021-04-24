using GetcuReone.Cdo.Configuration;
using GetcuReone.GetcuTestAdapter;
using GetcuReone.GwtTestFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace GetcuReone.configTests.Settings
{
    [TestClass]
    public sealed class SettingsTests : GetcuReoneTestBase
    {
        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Check the number of configs for settings.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void CheckCountConfigsTestCase()
        {
            const int expectedCount = 3;

            Given("Get GetcuReone config.", () => GrConfigManager.Current)
                .When("Get Settings config.", current => current.Sections[GrConfigKeys.Settings.Name].Configs)
                .ThenIsNotNull()
                .AndAreEqual(configs => configs.Count(), expectedCount)
                .Run();
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Check SettingsFolder config.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void CheckSettingsFolderTestCase()
        {
            const string expectedValue = "settins";

            Given("Get GetcuReone config.", () => GrConfigManager.Current)
                .When("Get Settings config.", current => current.Sections[GrConfigKeys.Settings.Name].Configs)
                .ThenAreEqual(configs => configs[GrConfigKeys.Settings.SettingsFolder].Value, expectedValue)
                .Run();
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Check TemplateSettingFile config.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void CheckTemplateSettingFileTestCase()
        {
            const string expectedValue = "GetcuReone_Settings*.xml";

            Given("Get GetcuReone config.", () => GrConfigManager.Current)
                .When("Get Settings config.", current => current.Sections[GrConfigKeys.Settings.Name].Configs)
                .ThenAreEqual(configs => configs[GrConfigKeys.Settings.TemplateSettingFile].Value, expectedValue)
                .Run();
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Check SettingTypesFile config.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void CheckSettingTypesFileTestCase()
        {
            const string expectedValue = @"settins\GetcuReone_SettingTypes.xml";

            Given("Get GetcuReone config.", () => GrConfigManager.Current)
                .When("Get Settings config.", current => current.Sections[GrConfigKeys.Settings.Name].Configs)
                .ThenAreEqual(configs => configs[GrConfigKeys.Settings.SettingTypesFile].Value, expectedValue)
                .Run();
        }
    }
}
