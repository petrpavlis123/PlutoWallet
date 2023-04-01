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


namespace PlutoWallet.NetApiExt.Generated.Model.xcm.v0.junction
{
    
    
    public enum Junction
    {
        
        Parent = 0,
        
        Parachain = 1,
        
        AccountId32 = 2,
        
        AccountIndex64 = 3,
        
        AccountKey20 = 4,
        
        PalletInstance = 5,
        
        GeneralIndex = 6,
        
        GeneralKey = 7,
        
        OnlyChild = 8,
        
        Plurality = 9,
    }
    
    /// <summary>
    /// >> 154 - Variant[xcm.v0.junction.Junction]
    /// </summary>
    public sealed class EnumJunction : BaseEnumExt<Junction, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v0.junction.EnumNetworkId, PlutoWallet.NetApiExt.Generated.Types.Base.Arr32U8>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v0.junction.EnumNetworkId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v0.junction.EnumNetworkId, PlutoWallet.NetApiExt.Generated.Types.Base.Arr20U8>, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, PlutoWallet.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT1, BaseVoid, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.xcm.v0.junction.EnumBodyId, PlutoWallet.NetApiExt.Generated.Model.xcm.v0.junction.EnumBodyPart>>
    {
    }
}
