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


namespace PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.pallet
{
    
    
    public enum Error
    {
        
        FirstPeriodInPast = 0,
        
        FirstPeriodTooFarInFuture = 1,
        
        LastPeriodBeforeFirstPeriod = 2,
        
        LastPeriodTooFarInFuture = 3,
        
        CannotEndInPast = 4,
        
        EndTooFarInFuture = 5,
        
        Overflow = 6,
        
        ContributionTooSmall = 7,
        
        InvalidParaId = 8,
        
        CapExceeded = 9,
        
        ContributionPeriodOver = 10,
        
        InvalidOrigin = 11,
        
        NotParachain = 12,
        
        LeaseActive = 13,
        
        BidOrLeaseActive = 14,
        
        FundNotEnded = 15,
        
        NoContributions = 16,
        
        NotReadyToDissolve = 17,
        
        InvalidSignature = 18,
        
        MemoTooLarge = 19,
        
        AlreadyInNewRaise = 20,
        
        VrfDelayInProgress = 21,
        
        NoLeasePeriod = 22,
    }
    
    /// <summary>
    /// >> 714 - Variant[polkadot_runtime_common.crowdloan.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
