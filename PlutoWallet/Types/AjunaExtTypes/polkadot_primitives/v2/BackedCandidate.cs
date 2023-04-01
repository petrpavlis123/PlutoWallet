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


namespace PlutoWallet.NetApiExt.Generated.Model.polkadot_primitives.v2
{
    
    
    /// <summary>
    /// >> 388 - Composite[polkadot_primitives.v2.BackedCandidate]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BackedCandidate : BaseType
    {
        
        /// <summary>
        /// >> candidate
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.polkadot_primitives.v2.CommittedCandidateReceipt _candidate;
        
        /// <summary>
        /// >> validity_votes
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.polkadot_primitives.v2.EnumValidityAttestation> _validityVotes;
        
        /// <summary>
        /// >> validator_indices
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, PlutoWallet.NetApiExt.Generated.Model.bitvec.order.Lsb0> _validatorIndices;
        
        public PlutoWallet.NetApiExt.Generated.Model.polkadot_primitives.v2.CommittedCandidateReceipt Candidate
        {
            get
            {
                return this._candidate;
            }
            set
            {
                this._candidate = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.polkadot_primitives.v2.EnumValidityAttestation> ValidityVotes
        {
            get
            {
                return this._validityVotes;
            }
            set
            {
                this._validityVotes = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, PlutoWallet.NetApiExt.Generated.Model.bitvec.order.Lsb0> ValidatorIndices
        {
            get
            {
                return this._validatorIndices;
            }
            set
            {
                this._validatorIndices = value;
            }
        }
        
        public override string TypeName()
        {
            return "BackedCandidate";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Candidate.Encode());
            result.AddRange(ValidityVotes.Encode());
            result.AddRange(ValidatorIndices.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Candidate = new PlutoWallet.NetApiExt.Generated.Model.polkadot_primitives.v2.CommittedCandidateReceipt();
            Candidate.Decode(byteArray, ref p);
            ValidityVotes = new Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.polkadot_primitives.v2.EnumValidityAttestation>();
            ValidityVotes.Decode(byteArray, ref p);
            ValidatorIndices = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, PlutoWallet.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
            ValidatorIndices.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
