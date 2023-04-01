//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras
{
    
    
    /// <summary>
    /// >> 672 - Composite[polkadot_runtime_parachains.paras.ParaPastCodeMeta]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ParaPastCodeMeta : BaseType
    {
        
        /// <summary>
        /// >> upgrade_times
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes> _upgradeTimes;
        
        /// <summary>
        /// >> last_pruned
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _lastPruned;
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes> UpgradeTimes
        {
            get
            {
                return this._upgradeTimes;
            }
            set
            {
                this._upgradeTimes = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> LastPruned
        {
            get
            {
                return this._lastPruned;
            }
            set
            {
                this._lastPruned = value;
            }
        }
        
        public override string TypeName()
        {
            return "ParaPastCodeMeta";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UpgradeTimes.Encode());
            result.AddRange(LastPruned.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UpgradeTimes = new Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes>();
            UpgradeTimes.Decode(byteArray, ref p);
            LastPruned = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            LastPruned.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
