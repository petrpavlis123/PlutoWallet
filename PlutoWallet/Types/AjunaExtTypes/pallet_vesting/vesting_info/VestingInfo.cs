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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_vesting.vesting_info
{
    
    
    /// <summary>
    /// >> 253 - Composite[pallet_vesting.vesting_info.VestingInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class VestingInfo : BaseType
    {
        
        /// <summary>
        /// >> locked
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _locked;
        
        /// <summary>
        /// >> per_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _perBlock;
        
        /// <summary>
        /// >> starting_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _startingBlock;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Locked
        {
            get
            {
                return this._locked;
            }
            set
            {
                this._locked = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 PerBlock
        {
            get
            {
                return this._perBlock;
            }
            set
            {
                this._perBlock = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 StartingBlock
        {
            get
            {
                return this._startingBlock;
            }
            set
            {
                this._startingBlock = value;
            }
        }
        
        public override string TypeName()
        {
            return "VestingInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Locked.Encode());
            result.AddRange(PerBlock.Encode());
            result.AddRange(StartingBlock.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Locked = new Substrate.NetApi.Model.Types.Primitive.U128();
            Locked.Decode(byteArray, ref p);
            PerBlock = new Substrate.NetApi.Model.Types.Primitive.U128();
            PerBlock.Decode(byteArray, ref p);
            StartingBlock = new Substrate.NetApi.Model.Types.Primitive.U32();
            StartingBlock.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
