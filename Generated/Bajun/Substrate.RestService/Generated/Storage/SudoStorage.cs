//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ISudoStorage interface definition.
    /// </summary>
    public interface ISudoStorage : IStorage
    {
        
        /// <summary>
        /// >> Key
        ///  The `AccountId` of the sudo key.
        /// </summary>
        Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetKey();
    }
    
    /// <summary>
    /// SudoStorage class definition.
    /// </summary>
    public sealed class SudoStorage : ISudoStorage
    {
        
        /// <summary>
        /// _keyTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32> _keyTypedStorage;
        
        /// <summary>
        /// SudoStorage constructor.
        /// </summary>
        public SudoStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.KeyTypedStorage = new TypedStorage<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>("Sudo.Key", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _keyTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32> KeyTypedStorage
        {
            get
            {
                return _keyTypedStorage;
            }
            set
            {
                _keyTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await KeyTypedStorage.InitializeAsync("Sudo", "Key");
        }
        
        /// <summary>
        /// Implements any storage change for Sudo.Key
        /// </summary>
        [StorageChange("Sudo", "Key")]
        public void OnUpdateKey(string data)
        {
            KeyTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Key
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetKey()
        {
            return KeyTypedStorage.Get();
        }
    }
}
