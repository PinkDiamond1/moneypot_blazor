//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyPot_RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Primitive;
   using MoneyPot_NetApiExt.Generated.Model.pallet_balances;
   using MoneyPot_NetApiExt.Generated.Model.sp_runtime.bounded.weak_bounded_vec;
   using MoneyPot_NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public interface IBalancesControllerClient
   {
      Task<U128> GetTotalIssuance();
      Task<bool> SubscribeTotalIssuance();
      Task<AccountData> GetAccount(MoneyPot_NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeAccount(MoneyPot_NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<WeakBoundedVecT2> GetLocks(MoneyPot_NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeLocks(MoneyPot_NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT3> GetReserves(MoneyPot_NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeReserves(MoneyPot_NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<EnumReleases> GetStorageVersion();
      Task<bool> SubscribeStorageVersion();
   }
}
