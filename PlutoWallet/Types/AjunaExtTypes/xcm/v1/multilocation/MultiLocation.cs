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


namespace PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation
{
    
    
    /// <summary>
    /// >> 122 - Composite[xcm.v1.multilocation.MultiLocation]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MultiLocation : BaseType
    {
        
        /// <summary>
        /// >> parents
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _parents;
        
        /// <summary>
        /// >> interior
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.EnumJunctions _interior;
        
        public Substrate.NetApi.Model.Types.Primitive.U8 Parents
        {
            get
            {
                return this._parents;
            }
            set
            {
                this._parents = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.EnumJunctions Interior
        {
            get
            {
                return this._interior;
            }
            set
            {
                this._interior = value;
            }
        }
        
        public override string TypeName()
        {
            return "MultiLocation";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Parents.Encode());
            result.AddRange(Interior.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Parents = new Substrate.NetApi.Model.Types.Primitive.U8();
            Parents.Decode(byteArray, ref p);
            Interior = new PlutoWallet.NetApiExt.Generated.Model.xcm.v1.multilocation.EnumJunctions();
            Interior.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
