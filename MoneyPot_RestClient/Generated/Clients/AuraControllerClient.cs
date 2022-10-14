//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyPot_RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using MoneyPot_NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using MoneyPot_NetApiExt.Generated.Model.sp_consensus_slots;
   using MoneyPot_RestClient.Generated.Interfaces;
   
   public sealed class AuraControllerClient : BaseClient, IAuraControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public AuraControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT2> GetAuthorities()
      {
         return await SendRequestAsync<BoundedVecT2>(_httpClient, "aura/authorities");
      }
      public async Task<bool> SubscribeAuthorities()
      {
         return await _subscriptionClient.SubscribeAsync("Aura.Authorities");
      }
      public async Task<Slot> GetCurrentSlot()
      {
         return await SendRequestAsync<Slot>(_httpClient, "aura/currentslot");
      }
      public async Task<bool> SubscribeCurrentSlot()
      {
         return await _subscriptionClient.SubscribeAsync("Aura.CurrentSlot");
      }
   }
}
