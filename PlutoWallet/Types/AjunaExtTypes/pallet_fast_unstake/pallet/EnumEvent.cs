//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_fast_unstake.pallet
{
    
    
    public enum Event
    {
        
        Unstaked = 0,
        
        Slashed = 1,
        
        InternalError = 2,
        
        BatchChecked = 3,
        
        BatchFinished = 4,
    }
    
    /// <summary>
    /// >> 93 - Variant[pallet_fast_unstake.pallet.Event]
    /// The events of this pallet.
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, PlutoWallet.NetApiExt.Generated.Types.Base.EnumResult>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>, BaseVoid>
    {
    }
}
