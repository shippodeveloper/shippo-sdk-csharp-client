using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippoSDK.Services;

namespace ShippoSDKTest
{
    [TestClass]
    public class LocationTest : BaseTest
    {
        private LocationService _locationService;

        public LocationTest()
        {
            _locationService = new LocationService(Config);
        }

        [TestMethod]
        public void TestGetLocation()
        {
            var expected = this._locationService.ReadByParams().Result;

            Assert.IsTrue(expected.Count > 0, "No data location return.");
        }

        [TestMethod]
        public void TestDetail()
        {
            var collection = this._locationService.ReadByParams().Result;
            var actual = collection[0];

            var expected = this._locationService.Detail(actual.Id).Result;
            Assert.AreEqual(actual.Name, expected.Name);
        }
    }
}