//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.RestService.Generated.Storage;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// PreimageController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class PreimageController : ControllerBase
    {
        
        private IPreimageStorage _preimageStorage;
        
        /// <summary>
        /// PreimageController constructor.
        /// </summary>
        public PreimageController(IPreimageStorage preimageStorage)
        {
            _preimageStorage = preimageStorage;
        }
        
        /// <summary>
        /// >> StatusFor
        ///  The request status of a given hash.
        /// </summary>
        [HttpGet("StatusFor")]
        [ProducesResponseType(typeof(Opal.NetApi.Generated.Model.pallet_preimage.EnumOldRequestStatus), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.PreimageStorage), "StatusForParams", typeof(Opal.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetStatusFor(string key)
        {
            return this.Ok(_preimageStorage.GetStatusFor(key));
        }
        
        /// <summary>
        /// >> RequestStatusFor
        ///  The request status of a given hash.
        /// </summary>
        [HttpGet("RequestStatusFor")]
        [ProducesResponseType(typeof(Opal.NetApi.Generated.Model.pallet_preimage.EnumRequestStatus), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.PreimageStorage), "RequestStatusForParams", typeof(Opal.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetRequestStatusFor(string key)
        {
            return this.Ok(_preimageStorage.GetRequestStatusFor(key));
        }
        
        /// <summary>
        /// >> PreimageFor
        /// </summary>
        [HttpGet("PreimageFor")]
        [ProducesResponseType(typeof(Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT27), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.PreimageStorage), "PreimageForParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetPreimageFor(string key)
        {
            return this.Ok(_preimageStorage.GetPreimageFor(key));
        }
    }
}
