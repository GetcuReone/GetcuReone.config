using GetcuReone.Cdo.Configuration;
using GetcuReone.GetcuTestAdapter;
using GetcuReone.GwtTestFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace GetcuReone.configTests.Logging
{
    [TestClass]
    public sealed class LoggingTests : GetcuReoneTestBase
    {
        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Check the number of configs for logging.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void CheckCountConfigsTestCase()
        {
            const int expectedCount = 1;

            Given("Get GetcuReone config.", () => GrConfigManager.Current)
                .When("Get Logging config.", current => current.Logging)
                .ThenIsNotNull()
                .AndAreEqual(configs => configs.Count(), expectedCount)
                .Run();
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Check nlog.LoggerName config.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void CheckNLogNameTestCase()
        {
            const string key = "nlog.loggerName";
            const string expectedValue = "GR_log";

            Given("Get GetcuReone config.", () => GrConfigManager.Current)
                .When("Get Logging config.", current => current.Logging)
                .ThenIsNotNull()
                .AndAreEqual(configs => configs[key].Value, expectedValue)
                .Run();
        }
    }
}
