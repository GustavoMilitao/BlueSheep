//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.DataCenter
{
    using System.Collections.Generic;
    using System;


    [Serializable()]
    public class Item : IData
    {
        
        public virtual int Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private int mId;
        
        public virtual uint NameId
        {
            get
            {
                return mNameId;
            }
            set
            {
                mNameId = value;
            }
        }
        
        private uint mNameId;
        
        public virtual uint TypeId
        {
            get
            {
                return mTypeId;
            }
            set
            {
                mTypeId = value;
            }
        }
        
        private uint mTypeId;
        
        public virtual uint DescriptionId
        {
            get
            {
                return mDescriptionId;
            }
            set
            {
                mDescriptionId = value;
            }
        }
        
        private uint mDescriptionId;
        
        public virtual uint IconId
        {
            get
            {
                return mIconId;
            }
            set
            {
                mIconId = value;
            }
        }
        
        private uint mIconId;
        
        public virtual uint Level
        {
            get
            {
                return mLevel;
            }
            set
            {
                mLevel = value;
            }
        }
        
        private uint mLevel;
        
        public virtual uint RealWeight
        {
            get
            {
                return mRealWeight;
            }
            set
            {
                mRealWeight = value;
            }
        }
        
        private uint mRealWeight;
        
        public virtual bool Cursed
        {
            get
            {
                return mCursed;
            }
            set
            {
                mCursed = value;
            }
        }
        
        private bool mCursed;
        
        public virtual int UseAnimationId
        {
            get
            {
                return mUseAnimationId;
            }
            set
            {
                mUseAnimationId = value;
            }
        }
        
        private int mUseAnimationId;
        
        public virtual bool Usable
        {
            get
            {
                return mUsable;
            }
            set
            {
                mUsable = value;
            }
        }
        
        private bool mUsable;
        
        public virtual bool Targetable
        {
            get
            {
                return mTargetable;
            }
            set
            {
                mTargetable = value;
            }
        }
        
        private bool mTargetable;
        
        public virtual bool Exchangeable
        {
            get
            {
                return mExchangeable;
            }
            set
            {
                mExchangeable = value;
            }
        }
        
        private bool mExchangeable;
        
        public virtual double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        
        private double mPrice;
        
        public virtual bool TwoHanded
        {
            get
            {
                return mTwoHanded;
            }
            set
            {
                mTwoHanded = value;
            }
        }
        
        private bool mTwoHanded;
        
        public virtual bool Etheral
        {
            get
            {
                return mEtheral;
            }
            set
            {
                mEtheral = value;
            }
        }
        
        private bool mEtheral;
        
        public virtual int ItemSetId
        {
            get
            {
                return mItemSetId;
            }
            set
            {
                mItemSetId = value;
            }
        }
        
        private int mItemSetId;
        
        public virtual string Criteria
        {
            get
            {
                return mCriteria;
            }
            set
            {
                mCriteria = value;
            }
        }
        
        private string mCriteria;
        
        public virtual string CriteriaTarget
        {
            get
            {
                return mCriteriaTarget;
            }
            set
            {
                mCriteriaTarget = value;
            }
        }
        
        private string mCriteriaTarget;
        
        public virtual bool HideEffects
        {
            get
            {
                return mHideEffects;
            }
            set
            {
                mHideEffects = value;
            }
        }
        
        private bool mHideEffects;
        
        public virtual bool Enhanceable
        {
            get
            {
                return mEnhanceable;
            }
            set
            {
                mEnhanceable = value;
            }
        }
        
        private bool mEnhanceable;
        
        public virtual bool NonUsableOnAnother
        {
            get
            {
                return mNonUsableOnAnother;
            }
            set
            {
                mNonUsableOnAnother = value;
            }
        }
        
        private bool mNonUsableOnAnother;
        
        public virtual uint AppearanceId
        {
            get
            {
                return mAppearanceId;
            }
            set
            {
                mAppearanceId = value;
            }
        }
        
        private uint mAppearanceId;
        
        public virtual bool SecretRecipe
        {
            get
            {
                return mSecretRecipe;
            }
            set
            {
                mSecretRecipe = value;
            }
        }
        
        private bool mSecretRecipe;
        
        public virtual List<uint> DropMonsterIds
        {
            get
            {
                return mDropMonsterIds;
            }
            set
            {
                mDropMonsterIds = value;
            }
        }
        
        private List<uint> mDropMonsterIds = new List<uint>();
        
        public virtual uint RecipeSlots
        {
            get
            {
                return mRecipeSlots;
            }
            set
            {
                mRecipeSlots = value;
            }
        }
        
        private uint mRecipeSlots;
        
        public virtual List<uint> RecipeIds
        {
            get
            {
                return mRecipeIds;
            }
            set
            {
                mRecipeIds = value;
            }
        }
        
        private List<uint> mRecipeIds = new List<uint>();
        
        public virtual bool BonusIsSecret
        {
            get
            {
                return mBonusIsSecret;
            }
            set
            {
                mBonusIsSecret = value;
            }
        }
        
        private bool mBonusIsSecret;
        
        public virtual List<EffectInstance> PossibleEffects
        {
            get
            {
                return mPossibleEffects;
            }
            set
            {
                mPossibleEffects = value;
            }
        }
        
        private List<EffectInstance> mPossibleEffects = new List<EffectInstance>();
        
        public virtual List<uint> FavoriteSubAreas
        {
            get
            {
                return mFavoriteSubAreas;
            }
            set
            {
                mFavoriteSubAreas = value;
            }
        }
        
        private List<uint> mFavoriteSubAreas = new List<uint>();
        
        public virtual uint FavoriteSubAreasBonus
        {
            get
            {
                return mFavoriteSubAreasBonus;
            }
            set
            {
                mFavoriteSubAreasBonus = value;
            }
        }
        
        private uint mFavoriteSubAreasBonus;
        
        public virtual int CraftXpRatio
        {
            get
            {
                return mCraftXpRatio;
            }
            set
            {
                mCraftXpRatio = value;
            }
        }
        
        private int mCraftXpRatio;
        
        public virtual bool NeedUseConfirm
        {
            get
            {
                return mNeedUseConfirm;
            }
            set
            {
                mNeedUseConfirm = value;
            }
        }
        
        private bool mNeedUseConfirm;
        
        public virtual bool IsDestructible
        {
            get
            {
                return mIsDestructible;
            }
            set
            {
                mIsDestructible = value;
            }
        }
        
        private bool mIsDestructible;
        
        public virtual List<List<double>> NuggetsBySubarea
        {
            get
            {
                return mNuggetsBySubarea;
            }
            set
            {
                mNuggetsBySubarea = value;
            }
        }
        
        private List<List<double>> mNuggetsBySubarea = new List<List<double>>();
        
        public virtual List<uint> ContainerIds
        {
            get
            {
                return mContainerIds;
            }
            set
            {
                mContainerIds = value;
            }
        }
        
        private List<uint> mContainerIds = new List<uint>();
        
        public virtual List<List<int>> ResourcesBySubarea
        {
            get
            {
                return mResourcesBySubarea;
            }
            set
            {
                mResourcesBySubarea = value;
            }
        }
        
        private List<List<int>> mResourcesBySubarea = new List<List<int>>();
        
        public Item()
        {
        }
    }
}
