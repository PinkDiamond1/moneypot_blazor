//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace MoneyPot_NetApiExt.Generated.Model.pallet_scheduler.pallet
{
    
    
    public enum Event
    {
        
        Scheduled = 0,
        
        Canceled = 1,
        
        Dispatched = 2,
        
        CallLookupFailed = 3,
    }
    
    /// <summary>
    /// >> 34 - Variant[pallet_scheduler.pallet.Event]
    /// Events type.
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>, MoneyPot_NetApiExt.Generated.Types.Base.EnumResult>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>, MoneyPot_NetApiExt.Generated.Model.frame_support.traits.schedule.EnumLookupError>>
    {
    }
}
