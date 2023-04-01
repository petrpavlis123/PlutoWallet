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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_bounties
{
    
    
    /// <summary>
    /// >> 591 - Composite[pallet_bounties.Bounty]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Bounty : BaseType
    {
        
        /// <summary>
        /// >> proposer
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _proposer;
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _value;
        
        /// <summary>
        /// >> fee
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _fee;
        
        /// <summary>
        /// >> curator_deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _curatorDeposit;
        
        /// <summary>
        /// >> bond
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _bond;
        
        /// <summary>
        /// >> status
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.pallet_bounties.EnumBountyStatus _status;
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Proposer
        {
            get
            {
                return this._proposer;
            }
            set
            {
                this._proposer = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Value
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
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 CuratorDeposit
        {
            get
            {
                return this._curatorDeposit;
            }
            set
            {
                this._curatorDeposit = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Bond
        {
            get
            {
                return this._bond;
            }
            set
            {
                this._bond = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.pallet_bounties.EnumBountyStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        public override string TypeName()
        {
            return "Bounty";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Proposer.Encode());
            result.AddRange(Value.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(CuratorDeposit.Encode());
            result.AddRange(Bond.Encode());
            result.AddRange(Status.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Proposer = new PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Proposer.Decode(byteArray, ref p);
            Value = new Substrate.NetApi.Model.Types.Primitive.U128();
            Value.Decode(byteArray, ref p);
            Fee = new Substrate.NetApi.Model.Types.Primitive.U128();
            Fee.Decode(byteArray, ref p);
            CuratorDeposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            CuratorDeposit.Decode(byteArray, ref p);
            Bond = new Substrate.NetApi.Model.Types.Primitive.U128();
            Bond.Decode(byteArray, ref p);
            Status = new PlutoWallet.NetApiExt.Generated.Model.pallet_bounties.EnumBountyStatus();
            Status.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
