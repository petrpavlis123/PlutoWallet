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
    /// AuraExtController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AuraExtController : ControllerBase
    {
        
        private IAuraExtStorage _auraExtStorage;
        
        /// <summary>
        /// AuraExtController constructor.
        /// </summary>
        public AuraExtController(IAuraExtStorage auraExtStorage)
        {
            _auraExtStorage = auraExtStorage;
        }
        
        /// <summary>
        /// >> Authorities
        ///  Serves as cache for the authorities.
        /// 
        ///  The authorities in AuRa are overwritten in `on_initialize` when we switch to a new session,
        ///  but we require the old authorities to verify the seal when validating a PoV. This will
        ///  always be updated to the latest AuRa authorities in `on_finalize`.
        /// </summary>
        [HttpGet("Authorities")]
        [ProducesResponseType(typeof(Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.AuraExtStorage), "AuthoritiesParams")]
        public IActionResult GetAuthorities()
        {
            return this.Ok(_auraExtStorage.GetAuthorities());
        }
        
        /// <summary>
        /// >> SlotInfo
        ///  Current slot paired with a number of authored blocks.
        /// 
        ///  Updated on each block initialization.
        /// </summary>
        [HttpGet("SlotInfo")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.AuraExtStorage), "SlotInfoParams")]
        public IActionResult GetSlotInfo()
        {
            return this.Ok(_auraExtStorage.GetSlotInfo());
        }
    }
}
