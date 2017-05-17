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
    public class Quest : IData
    {
        
        public virtual uint Id
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
        
        private uint mId;
        
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
        
        public virtual List<uint> StepIds
        {
            get
            {
                return mStepIds;
            }
            set
            {
                mStepIds = value;
            }
        }
        
        private List<uint> mStepIds = new List<uint>();
        
        public virtual uint CategoryId
        {
            get
            {
                return mCategoryId;
            }
            set
            {
                mCategoryId = value;
            }
        }
        
        private uint mCategoryId;
        
        public virtual uint RepeatType
        {
            get
            {
                return mRepeatType;
            }
            set
            {
                mRepeatType = value;
            }
        }
        
        private uint mRepeatType;
        
        public virtual uint RepeatLimit
        {
            get
            {
                return mRepeatLimit;
            }
            set
            {
                mRepeatLimit = value;
            }
        }
        
        private uint mRepeatLimit;
        
        public virtual bool IsDungeonQuest
        {
            get
            {
                return mIsDungeonQuest;
            }
            set
            {
                mIsDungeonQuest = value;
            }
        }
        
        private bool mIsDungeonQuest;
        
        public virtual uint LevelMin
        {
            get
            {
                return mLevelMin;
            }
            set
            {
                mLevelMin = value;
            }
        }
        
        private uint mLevelMin;
        
        public virtual uint LevelMax
        {
            get
            {
                return mLevelMax;
            }
            set
            {
                mLevelMax = value;
            }
        }
        
        private uint mLevelMax;
        
        public virtual bool IsPartyQuest
        {
            get
            {
                return mIsPartyQuest;
            }
            set
            {
                mIsPartyQuest = value;
            }
        }
        
        private bool mIsPartyQuest;
        
        public virtual string StartCriterion
        {
            get
            {
                return mStartCriterion;
            }
            set
            {
                mStartCriterion = value;
            }
        }
        
        private string mStartCriterion;
        
        public Quest()
        {
        }
    }
}
