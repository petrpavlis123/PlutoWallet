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


namespace PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_common.claims
{
    
    
    /// <summary>
    /// >> 73 - Composite[polkadot_runtime_common.claims.EthereumAddress]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EthereumAddress : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Types.Base.Arr20U8 _value;
        
        public PlutoWallet.NetApiExt.Generated.Types.Base.Arr20U8 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "EthereumAddress";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new PlutoWallet.NetApiExt.Generated.Types.Base.Arr20U8();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
