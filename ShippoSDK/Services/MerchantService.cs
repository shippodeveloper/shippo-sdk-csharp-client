using System.Threading.Tasks;
using Newtonsoft.Json;
using ShippoSDK.Interfaces;
using ShippoSDK.Models;

namespace ShippoSDK.Services
{
    public class MerchantService : BaseService<IMerchant>
    {
        public MerchantService(ConfigModel configModel) : base(configModel)
        {
        }

        /**
        * Get merchant profiles
        *
        * @return null | MerchantModel
        * @throws Exception | ShippoSDKException
        */
        public async Task<MerchantModel> Profiles()
        {
            var response = await Api.ReadOne();
            
            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var merchantModel = JsonConvert.DeserializeObject<ResultModel<MerchantModel>>(response.StringContent);
            return merchantModel.Result;
        }
    }
}