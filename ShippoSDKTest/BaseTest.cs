using ShippoSDK.Models;

namespace ShippoSDKTest
{
    public abstract class BaseTest
    {
        protected readonly ConfigModel Config;

        protected BaseTest()
        {
            Config = new ConfigModel
            {
                AccessToken = "a86988bfe20d23e54b53af8ea1140f98c6233dce",
                BaseUri = "https://sandbox-apix.shippo.vn"
            };
        }
    }
}