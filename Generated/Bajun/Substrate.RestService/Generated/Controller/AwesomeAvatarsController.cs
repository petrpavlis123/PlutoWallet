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
    /// AwesomeAvatarsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AwesomeAvatarsController : ControllerBase
    {
        
        private IAwesomeAvatarsStorage _awesomeAvatarsStorage;
        
        /// <summary>
        /// AwesomeAvatarsController constructor.
        /// </summary>
        public AwesomeAvatarsController(IAwesomeAvatarsStorage awesomeAvatarsStorage)
        {
            _awesomeAvatarsStorage = awesomeAvatarsStorage;
        }
        
        /// <summary>
        /// >> Organizer
        /// </summary>
        [HttpGet("Organizer")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "OrganizerParams")]
        public IActionResult GetOrganizer()
        {
            return this.Ok(_awesomeAvatarsStorage.GetOrganizer());
        }
        
        /// <summary>
        /// >> Treasurer
        /// </summary>
        [HttpGet("Treasurer")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "TreasurerParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetTreasurer(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTreasurer(key));
        }
        
        /// <summary>
        /// >> WhitelistedAccounts
        ///  List of accounts allowed to transfer free mints.
        ///  A maximum of 3 different accounts can be on the list.
        /// </summary>
        [HttpGet("WhitelistedAccounts")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT51), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "WhitelistedAccountsParams")]
        public IActionResult GetWhitelistedAccounts()
        {
            return this.Ok(_awesomeAvatarsStorage.GetWhitelistedAccounts());
        }
        
        /// <summary>
        /// >> CurrentSeasonStatus
        /// </summary>
        [HttpGet("CurrentSeasonStatus")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonStatus), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "CurrentSeasonStatusParams")]
        public IActionResult GetCurrentSeasonStatus()
        {
            return this.Ok(_awesomeAvatarsStorage.GetCurrentSeasonStatus());
        }
        
        /// <summary>
        /// >> Seasons
        ///  Storage for the seasons.
        /// </summary>
        [HttpGet("Seasons")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "SeasonsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetSeasons(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasons(key));
        }
        
        /// <summary>
        /// >> SeasonMetas
        ///  Storage for the season's metadata.
        /// </summary>
        [HttpGet("SeasonMetas")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonMeta), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "SeasonMetasParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetSeasonMetas(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasonMetas(key));
        }
        
        /// <summary>
        /// >> SeasonSchedules
        ///  Storage for the season's schedules.
        /// </summary>
        [HttpGet("SeasonSchedules")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonSchedule), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "SeasonSchedulesParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetSeasonSchedules(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasonSchedules(key));
        }
        
        /// <summary>
        /// >> SeasonTradeFilters
        ///  Storage for the season's trade filters.
        /// </summary>
        [HttpGet("SeasonTradeFilters")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.TradeFilters), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "SeasonTradeFiltersParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetSeasonTradeFilters(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasonTradeFilters(key));
        }
        
        /// <summary>
        /// >> SeasonUnlocks
        ///  Storage for the season's different unlock-ables.
        /// </summary>
        [HttpGet("SeasonUnlocks")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.UnlockConfigs), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "SeasonUnlocksParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetSeasonUnlocks(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasonUnlocks(key));
        }
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        [HttpGet("Treasury")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "TreasuryParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetTreasury(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTreasury(key));
        }
        
        /// <summary>
        /// >> GlobalConfigs
        /// </summary>
        [HttpGet("GlobalConfigs")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "GlobalConfigsParams")]
        public IActionResult GetGlobalConfigs()
        {
            return this.Ok(_awesomeAvatarsStorage.GetGlobalConfigs());
        }
        
        /// <summary>
        /// >> Avatars
        /// </summary>
        [HttpGet("Avatars")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar>), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "AvatarsParams", typeof(Bajun.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetAvatars(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetAvatars(key));
        }
        
        /// <summary>
        /// >> Owners
        /// </summary>
        [HttpGet("Owners")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT52), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "OwnersParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16>))]
        public IActionResult GetOwners(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetOwners(key));
        }
        
        /// <summary>
        /// >> LockedAvatars
        /// </summary>
        [HttpGet("LockedAvatars")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "LockedAvatarsParams", typeof(Bajun.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetLockedAvatars(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetLockedAvatars(key));
        }
        
        /// <summary>
        /// >> CollectionId
        /// </summary>
        [HttpGet("CollectionId")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "CollectionIdParams")]
        public IActionResult GetCollectionId()
        {
            return this.Ok(_awesomeAvatarsStorage.GetCollectionId());
        }
        
        /// <summary>
        /// >> PlayerConfigs
        /// </summary>
        [HttpGet("PlayerConfigs")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayerConfig), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "PlayerConfigsParams", typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetPlayerConfigs(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetPlayerConfigs(key));
        }
        
        /// <summary>
        /// >> PlayerSeasonConfigs
        /// </summary>
        [HttpGet("PlayerSeasonConfigs")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayerSeasonConfig), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "PlayerSeasonConfigsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16>))]
        public IActionResult GetPlayerSeasonConfigs(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetPlayerSeasonConfigs(key));
        }
        
        /// <summary>
        /// >> TradeStatsMap
        ///  This is only an intermediate storage that is being used during the multiblock runtime
        ///  migration of v5 to v6. It should be removed afterward.
        /// </summary>
        [HttpGet("TradeStatsMap")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "TradeStatsMapParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetTradeStatsMap(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTradeStatsMap(key));
        }
        
        /// <summary>
        /// >> SeasonStats
        /// </summary>
        [HttpGet("SeasonStats")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "SeasonStatsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetSeasonStats(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasonStats(key));
        }
        
        /// <summary>
        /// >> Trade
        /// </summary>
        [HttpGet("Trade")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "TradeParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.primitive_types.H256>))]
        public IActionResult GetTrade(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTrade(key));
        }
        
        /// <summary>
        /// >> ServiceAccount
        /// </summary>
        [HttpGet("ServiceAccount")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "ServiceAccountParams")]
        public IActionResult GetServiceAccount()
        {
            return this.Ok(_awesomeAvatarsStorage.GetServiceAccount());
        }
        
        /// <summary>
        /// >> Preparation
        /// </summary>
        [HttpGet("Preparation")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "PreparationParams", typeof(Bajun.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetPreparation(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetPreparation(key));
        }
        
        /// <summary>
        /// >> TournamentRankers
        /// </summary>
        [HttpGet("TournamentRankers")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.tournament.AvatarRanker), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.AwesomeAvatarsStorage), "TournamentRankersParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetTournamentRankers(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTournamentRankers(key));
        }
    }
}
