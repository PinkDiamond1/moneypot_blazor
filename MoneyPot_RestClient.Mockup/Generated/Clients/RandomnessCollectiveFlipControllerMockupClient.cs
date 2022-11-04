//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyPot_RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using MoneyPot_NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using MoneyPot_RestClient.Mockup.Generated.Interfaces;
   
   public sealed class RandomnessCollectiveFlipControllerMockupClient : MockupBaseClient, IRandomnessCollectiveFlipControllerMockupClient
   {
      private HttpClient _httpClient;
      public RandomnessCollectiveFlipControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetRandomMaterial(BoundedVecT1 value)
      {
         return await SendMockupRequestAsync(_httpClient, "RandomnessCollectiveFlip/RandomMaterial", value.Encode(), MoneyPot_NetApiExt.Generated.Storage.RandomnessCollectiveFlipStorage.RandomMaterialParams());
      }
   }
}
