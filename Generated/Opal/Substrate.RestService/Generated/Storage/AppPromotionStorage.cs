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
    /// IAppPromotionStorage interface definition.
    /// </summary>
    public interface IAppPromotionStorage : IStorage
    {
        
        /// <summary>
        /// >> TotalStaked
        ///  Stores the total staked amount.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetTotalStaked();
        
        /// <summary>
        /// >> Admin
        ///  Stores the `admin` account. Some extrinsics can only be executed if they were signed by `admin`.
        /// </summary>
        Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetAdmin();
        
        /// <summary>
        /// >> Staked
        ///  Stores the amount of tokens staked by account in the blocknumber.
        /// 
        ///  * **Key1** - Staker account.
        ///  * **Key2** - Relay block number when the stake was made.
        ///  * **(Balance, BlockNumber)** - Balance of the stake.
        ///  The number of the relay block in which we must perform the interest recalculation
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32> GetStaked(string key);
        
        /// <summary>
        /// >> StakesPerAccount
        ///  Stores number of stake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U8 GetStakesPerAccount(string key);
        
        /// <summary>
        /// >> PendingUnstake
        ///  Pending unstake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42 GetPendingUnstake(string key);
        
        /// <summary>
        /// >> PreviousCalculatedRecord
        ///  Stores a key for record for which the revenue recalculation was performed.
        ///  If `None`, then recalculation has not yet been performed or calculations have been completed for all stakers.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> GetPreviousCalculatedRecord();
    }
    
    /// <summary>
    /// AppPromotionStorage class definition.
    /// </summary>
    public sealed class AppPromotionStorage : IAppPromotionStorage
    {
        
        /// <summary>
        /// _totalStakedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _totalStakedTypedStorage;
        
        /// <summary>
        /// _adminTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32> _adminTypedStorage;
        
        /// <summary>
        /// _stakedTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>> _stakedTypedStorage;
        
        /// <summary>
        /// _stakesPerAccountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U8> _stakesPerAccountTypedStorage;
        
        /// <summary>
        /// _pendingUnstakeTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42> _pendingUnstakeTypedStorage;
        
        /// <summary>
        /// _previousCalculatedRecordTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>> _previousCalculatedRecordTypedStorage;
        
        /// <summary>
        /// AppPromotionStorage constructor.
        /// </summary>
        public AppPromotionStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.TotalStakedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("AppPromotion.TotalStaked", storageDataProvider, storageChangeDelegates);
            this.AdminTypedStorage = new TypedStorage<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32>("AppPromotion.Admin", storageDataProvider, storageChangeDelegates);
            this.StakedTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>("AppPromotion.Staked", storageDataProvider, storageChangeDelegates);
            this.StakesPerAccountTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U8>("AppPromotion.StakesPerAccount", storageDataProvider, storageChangeDelegates);
            this.PendingUnstakeTypedStorage = new TypedMapStorage<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42>("AppPromotion.PendingUnstake", storageDataProvider, storageChangeDelegates);
            this.PreviousCalculatedRecordTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>("AppPromotion.PreviousCalculatedRecord", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _totalStakedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> TotalStakedTypedStorage
        {
            get
            {
                return _totalStakedTypedStorage;
            }
            set
            {
                _totalStakedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _adminTypedStorage property
        /// </summary>
        public TypedStorage<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32> AdminTypedStorage
        {
            get
            {
                return _adminTypedStorage;
            }
            set
            {
                _adminTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _stakedTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>> StakedTypedStorage
        {
            get
            {
                return _stakedTypedStorage;
            }
            set
            {
                _stakedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _stakesPerAccountTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U8> StakesPerAccountTypedStorage
        {
            get
            {
                return _stakesPerAccountTypedStorage;
            }
            set
            {
                _stakesPerAccountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _pendingUnstakeTypedStorage property
        /// </summary>
        public TypedMapStorage<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42> PendingUnstakeTypedStorage
        {
            get
            {
                return _pendingUnstakeTypedStorage;
            }
            set
            {
                _pendingUnstakeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _previousCalculatedRecordTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>> PreviousCalculatedRecordTypedStorage
        {
            get
            {
                return _previousCalculatedRecordTypedStorage;
            }
            set
            {
                _previousCalculatedRecordTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TotalStakedTypedStorage.InitializeAsync("AppPromotion", "TotalStaked");
            await AdminTypedStorage.InitializeAsync("AppPromotion", "Admin");
            await StakedTypedStorage.InitializeAsync("AppPromotion", "Staked");
            await StakesPerAccountTypedStorage.InitializeAsync("AppPromotion", "StakesPerAccount");
            await PendingUnstakeTypedStorage.InitializeAsync("AppPromotion", "PendingUnstake");
            await PreviousCalculatedRecordTypedStorage.InitializeAsync("AppPromotion", "PreviousCalculatedRecord");
        }
        
        /// <summary>
        /// Implements any storage change for AppPromotion.TotalStaked
        /// </summary>
        [StorageChange("AppPromotion", "TotalStaked")]
        public void OnUpdateTotalStaked(string data)
        {
            TotalStakedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> TotalStaked
        ///  Stores the total staked amount.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetTotalStaked()
        {
            return TotalStakedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AppPromotion.Admin
        /// </summary>
        [StorageChange("AppPromotion", "Admin")]
        public void OnUpdateAdmin(string data)
        {
            AdminTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Admin
        ///  Stores the `admin` account. Some extrinsics can only be executed if they were signed by `admin`.
        /// </summary>
        public Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetAdmin()
        {
            return AdminTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AppPromotion.Staked
        /// </summary>
        [StorageChange("AppPromotion", "Staked")]
        public void OnUpdateStaked(string key, string data)
        {
            StakedTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Staked
        ///  Stores the amount of tokens staked by account in the blocknumber.
        /// 
        ///  * **Key1** - Staker account.
        ///  * **Key2** - Relay block number when the stake was made.
        ///  * **(Balance, BlockNumber)** - Balance of the stake.
        ///  The number of the relay block in which we must perform the interest recalculation
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32> GetStaked(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (StakedTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AppPromotion.StakesPerAccount
        /// </summary>
        [StorageChange("AppPromotion", "StakesPerAccount")]
        public void OnUpdateStakesPerAccount(string key, string data)
        {
            StakesPerAccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> StakesPerAccount
        ///  Stores number of stake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 GetStakesPerAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (StakesPerAccountTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U8 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AppPromotion.PendingUnstake
        /// </summary>
        [StorageChange("AppPromotion", "PendingUnstake")]
        public void OnUpdatePendingUnstake(string key, string data)
        {
            PendingUnstakeTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> PendingUnstake
        ///  Pending unstake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        public Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42 GetPendingUnstake(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PendingUnstakeTypedStorage.Dictionary.TryGetValue(key, out Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AppPromotion.PreviousCalculatedRecord
        /// </summary>
        [StorageChange("AppPromotion", "PreviousCalculatedRecord")]
        public void OnUpdatePreviousCalculatedRecord(string data)
        {
            PreviousCalculatedRecordTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PreviousCalculatedRecord
        ///  Stores a key for record for which the revenue recalculation was performed.
        ///  If `None`, then recalculation has not yet been performed or calculations have been completed for all stakers.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> GetPreviousCalculatedRecord()
        {
            return PreviousCalculatedRecordTypedStorage.Get();
        }
    }
}
