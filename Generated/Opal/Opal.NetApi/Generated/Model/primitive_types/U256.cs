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


namespace Opal.NetApi.Generated.Model.primitive_types
{
    
    
    /// <summary>
    /// >> 334 - Composite[primitive_types.U256]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class U256 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        public Opal.NetApi.Generated.Types.Base.Arr4U64 Value { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "U256";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Opal.NetApi.Generated.Types.Base.Arr4U64();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
