using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShippoSDK.Interfaces;
using ShippoSDK.Models;

namespace ShippoSDK.Services
{
    public class PickupAddressService : BaseService<IPickupAddress>
    {
        public PickupAddressService(ConfigModel configModel) : base(configModel)
        {
        }

        /**
        * Get list of pickup addresses
        *
        * @return Collection
        * @throws Exception || ShippoSDKException
        */
        public async Task<List<PickupAddressModel>> Get()
        {
            var response = await Api.ReadAll();

            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var listPickupAddress =
                JsonConvert.DeserializeObject<ResultModel<List<PickupAddressModel>>>(response.StringContent);
            return listPickupAddress.Result;
        }

        /**
        * Create new merchant's pickup address
        *
        * @param param
        * @return PickupAddressModel
        * @throws Exception | ShippoSDKException
        */
        public async Task<PickupAddressModel> Create(PickupAddressModel param)
        {
            var response = await Api.Create(param);

            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var pickupAddress = JsonConvert.DeserializeObject<PickupAddressModel>(response.StringContent);            
            return pickupAddress;
        }

        /**
        * @param int id
        * @return PickupAddressModel | null
        * @throws Exception | ShippoSDKException
        */
        public async Task<PickupAddressModel> Detail(int id)
        {
            var response = await Api.ReadOne(id);
            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var pickupAddress = JsonConvert.DeserializeObject<ResultModel<PickupAddressModel>>(response.StringContent);
            return pickupAddress.Result;
        }

        /**
        * @param int id
        * @param param
        * @return PickupAddressModel | null
        * @throws Exception | ShippoSDKException
        */
        public async Task<PickupAddressModel> Edit(int id, PickupAddressModel param)
        {
            var response = await Api.Update(id, param);
            
            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var pickupAddress = JsonConvert.DeserializeObject<PickupAddressModel>(response.StringContent);
            return pickupAddress;
        }

        /**
        * @param int id
        * @return bool
        * @throws Exception | ShippoSDKException
        */
        public async Task<bool> Delete(int id)
        {
            var response = await Api.Delete(id);

            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            return response.ResponseMessage.StatusCode == HttpStatusCode.OK;
        }
    }
}