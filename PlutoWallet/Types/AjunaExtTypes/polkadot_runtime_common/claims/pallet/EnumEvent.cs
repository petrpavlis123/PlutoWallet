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


namespace PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_common.claims.pallet
{
    
    
    public enum Event
    {
        
        Claimed = 0,
    }
    
    /// <summary>
    /// >> 72 - Variant[polkadot_runtime_common.claims.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_common.claims.EthereumAddress, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
