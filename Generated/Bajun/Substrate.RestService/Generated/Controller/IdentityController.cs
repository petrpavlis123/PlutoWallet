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
    /// IdentityController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class IdentityController : ControllerBase
    {
        
        private IIdentityStorage _identityStorage;
        
        /// <summary>
        /// IdentityController constructor.
        /// </summary>
        public IdentityController(IIdentityStorage identityStorage)
        {
            _identityStorage = identityStorage;
        }
        
        /// <summary>
        /// >> IdentityOf
        ///  Information that is pertinent to identify the entity behind an account. First item is the
        ///  registration, second is the account's primary username.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        [HttpGet("IdentityOf")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bajun.NetApi.Generated.Model.pallet_identity.types.Registration, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>>), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.IdentityStorage), "IdentityOfParams", typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetIdentityOf(string key)
        {
            return this.Ok(_identityStorage.GetIdentityOf(key));
        }
        
        /// <summary>
        /// >> SuperOf
        ///  The super-identity of an alternative "sub" identity together with its name, within that
        ///  context. If the account is not some other account's sub-identity, then just `None`.
        /// </summary>
        [HttpGet("SuperOf")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.pallet_identity.types.EnumData>), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.IdentityStorage), "SuperOfParams", typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetSuperOf(string key)
        {
            return this.Ok(_identityStorage.GetSuperOf(key));
        }
        
        /// <summary>
        /// >> SubsOf
        ///  Alternative "sub" identities of this account.
        /// 
        ///  The first item is the deposit, the second is a vector of the accounts.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        [HttpGet("SubsOf")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT25>), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.IdentityStorage), "SubsOfParams", typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetSubsOf(string key)
        {
            return this.Ok(_identityStorage.GetSubsOf(key));
        }
        
        /// <summary>
        /// >> Registrars
        ///  The set of registrars. Not expected to get very big as can only be added through a
        ///  special origin (likely a council motion).
        /// 
        ///  The index into this can be cast to `RegistrarIndex` to get a valid value.
        /// </summary>
        [HttpGet("Registrars")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.IdentityStorage), "RegistrarsParams")]
        public IActionResult GetRegistrars()
        {
            return this.Ok(_identityStorage.GetRegistrars());
        }
        
        /// <summary>
        /// >> UsernameAuthorities
        ///  A map of the accounts who are authorized to grant usernames.
        /// </summary>
        [HttpGet("UsernameAuthorities")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.pallet_identity.types.AuthorityProperties), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.IdentityStorage), "UsernameAuthoritiesParams", typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetUsernameAuthorities(string key)
        {
            return this.Ok(_identityStorage.GetUsernameAuthorities(key));
        }
        
        /// <summary>
        /// >> AccountOfUsername
        ///  Reverse lookup from `username` to the `AccountId` that has registered it. The value should
        ///  be a key in the `IdentityOf` map, but it may not if the user has cleared their identity.
        /// 
        ///  Multiple usernames may map to the same `AccountId`, but `IdentityOf` will only map to one
        ///  primary username.
        /// </summary>
        [HttpGet("AccountOfUsername")]
        [ProducesResponseType(typeof(Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.IdentityStorage), "AccountOfUsernameParams", typeof(Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1))]
        public IActionResult GetAccountOfUsername(string key)
        {
            return this.Ok(_identityStorage.GetAccountOfUsername(key));
        }
        
        /// <summary>
        /// >> PendingUsernames
        ///  Usernames that an authority has granted, but that the account controller has not confirmed
        ///  that they want it. Used primarily in cases where the `AccountId` cannot provide a signature
        ///  because they are a pure proxy, multisig, etc. In order to confirm it, they should call
        ///  [`Call::accept_username`].
        /// 
        ///  First tuple item is the account and second is the acceptance deadline.
        /// </summary>
        [HttpGet("PendingUsernames")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Bajun.NetApi.Generated.Storage.IdentityStorage), "PendingUsernamesParams", typeof(Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1))]
        public IActionResult GetPendingUsernames(string key)
        {
            return this.Ok(_identityStorage.GetPendingUsernames(key));
        }
    }
}
