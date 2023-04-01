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


namespace PlutoWallet.NetApiExt.Generated.Model.xcm.v1.order
{
    
    
    public enum Order
    {
        
        Noop = 0,
        
        DepositAsset = 1,
        
        DepositReserveAsset = 2,
        
        ExchangeAsset = 3,
        
        InitiateReserveWithdraw = 4,
        
        InitiateTeleport = 5,
        
        QueryHolding = 6,
        
        BuyExecution = 7,
    }
    
    /// <summary>
    /// >> 443 - Variant[xcm.v1.order.Order]
    /// </summary>
    public sealed class EnumOrder : BaseEnumExt<Order, BaseVoid, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.order.EnumOrder>>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.order.EnumOrder>>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.order.EnumOrder>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAsset, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.xcm.v1.EnumXcm>>>
    {
    }
}
