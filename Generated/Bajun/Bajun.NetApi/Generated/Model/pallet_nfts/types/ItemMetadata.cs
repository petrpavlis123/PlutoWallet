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


namespace Bajun.NetApi.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 628 - Composite[pallet_nfts.types.ItemMetadata]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ItemMetadata : BaseType
    {
        
        /// <summary>
        /// >> deposit
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_nfts.types.ItemMetadataDeposit Deposit { get; set; }
        /// <summary>
        /// >> data
        /// </summary>
        public Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11 Data { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ItemMetadata";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Deposit.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Deposit = new Bajun.NetApi.Generated.Model.pallet_nfts.types.ItemMetadataDeposit();
            Deposit.Decode(byteArray, ref p);
            Data = new Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11();
            Data.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
