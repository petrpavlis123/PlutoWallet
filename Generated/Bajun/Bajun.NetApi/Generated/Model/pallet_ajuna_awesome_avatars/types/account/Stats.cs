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


namespace Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account
{
    
    
    /// <summary>
    /// >> 607 - Composite[pallet_ajuna_awesome_avatars.types.account.Stats]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Stats : BaseType
    {
        
        /// <summary>
        /// >> mint
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats Mint { get; set; }
        /// <summary>
        /// >> forge
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats Forge { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Stats";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Mint.Encode());
            result.AddRange(Forge.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Mint = new Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats();
            Mint.Decode(byteArray, ref p);
            Forge = new Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats();
            Forge.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
