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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_balances
{
    
    
    /// <summary>
    /// >> 475 - Composite[pallet_balances.ReserveData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ReserveData : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Types.Base.Arr8U8 _id;
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _amount;
        
        public PlutoWallet.NetApiExt.Generated.Types.Base.Arr8U8 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public override string TypeName()
        {
            return "ReserveData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Amount.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new PlutoWallet.NetApiExt.Generated.Types.Base.Arr8U8();
            Id.Decode(byteArray, ref p);
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
