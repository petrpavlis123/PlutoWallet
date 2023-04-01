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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_staking
{
    
    
    /// <summary>
    /// >> 491 - Composite[pallet_staking.ActiveEraInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ActiveEraInfo : BaseType
    {
        
        /// <summary>
        /// >> index
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _index;
        
        /// <summary>
        /// >> start
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64> _start;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64> Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public override string TypeName()
        {
            return "ActiveEraInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Index.Encode());
            result.AddRange(Start.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Index = new Substrate.NetApi.Model.Types.Primitive.U32();
            Index.Decode(byteArray, ref p);
            Start = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>();
            Start.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
