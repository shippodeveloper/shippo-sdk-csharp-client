using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippoSDK.Services;

namespace ShippoSDKTest
{
    [TestClass]
    public class MerchantTest : BaseTest
    {
        private MerchantService _merchantService;

        public MerchantTest()
        {
            _merchantService = new MerchantService(Config);
        }

        [TestMethod]
        public void TestProfile()
        {
            var expected = this._merchantService.Profiles().Result;
            const string actual = "demo@gmail.com";
            Assert.AreEqual(expected.Email, actual);
        }
    }
}