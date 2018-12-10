using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShippoSDK.Interfaces;
using ShippoSDK.Models;

namespace ShippoSDK.Services
{
    public class LocationService : BaseService<ILocation>
    {
        public LocationService(ConfigModel configModel) : base(configModel)
        {
        }

        /**
        * Get Shippo's locations
        * @link https://open-api.shippo.vn/api-endpoints/dia-diem#lay-danh-sach-tat-ca-dia-danh
        * @param param | null
        * @return Collection
        * @throws Exception | ShippoSDKException
        */
        public async Task<List<LocationModel>> ReadByParams(LocationModel paramLocationModel = null)
        {
            var response = await Api.ReadByParams(paramLocationModel);

            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var listLocationModel =
                JsonConvert.DeserializeObject<ResultModel<List<LocationModel>>>(response.StringContent);
            return listLocationModel.Result;
        }

        /**
        * Get location detail by id
        * @link https://open-api.shippo.vn/api-endpoints/dia-diem#chi-tiet-dia-danh
        * @param int id
        * @return LocationModel | null
        * @throws Exception | ShippoSDKException
        */
        public async Task<LocationModel> Detail(int id)
        {
            var response = await Api.ReadOne(id);

            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var locationModel = JsonConvert.DeserializeObject<ResultModel<LocationModel>>(response.StringContent);
            return locationModel.Result;
        }
    }
}