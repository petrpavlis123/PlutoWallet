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
    /// VestingController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class VestingController : ControllerBase
    {
        
        private IVestingStorage _vestingStorage;
        
        /// <summary>
        /// VestingController constructor.
        /// </summary>
        public VestingController(IVestingStorage vestingStorage)
        {
            _vestingStorage = vestingStorage;
        }
        
        /// <summary>
        /// >> VestingSchedules
        ///  Vesting schedules of an account.
        /// 
        ///  VestingSchedules: map AccountId => Vec<VestingSchedule>
        /// </summary>
        [HttpGet("VestingSchedules")]
        [ProducesResponseType(typeof(Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT24), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.VestingStorage), "VestingSchedulesParams", typeof(Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetVestingSchedules(string key)
        {
            return this.Ok(_vestingStorage.GetVestingSchedules(key));
        }
    }
}
