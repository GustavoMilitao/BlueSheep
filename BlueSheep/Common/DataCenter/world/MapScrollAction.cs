//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.DataCenter
{
    using System;


    [Serializable()]
    public class MapScrollAction : IData
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
        
        public virtual bool RightExists
        {
            get
            {
                return mRightExists;
            }
            set
            {
                mRightExists = value;
            }
        }
        
        private bool mRightExists;
        
        public virtual bool BottomExists
        {
            get
            {
                return mBottomExists;
            }
            set
            {
                mBottomExists = value;
            }
        }
        
        private bool mBottomExists;
        
        public virtual bool LeftExists
        {
            get
            {
                return mLeftExists;
            }
            set
            {
                mLeftExists = value;
            }
        }
        
        private bool mLeftExists;
        
        public virtual bool TopExists
        {
            get
            {
                return mTopExists;
            }
            set
            {
                mTopExists = value;
            }
        }
        
        private bool mTopExists;
        
        public virtual int RightMapId
        {
            get
            {
                return mRightMapId;
            }
            set
            {
                mRightMapId = value;
            }
        }
        
        private int mRightMapId;
        
        public virtual int BottomMapId
        {
            get
            {
                return mBottomMapId;
            }
            set
            {
                mBottomMapId = value;
            }
        }
        
        private int mBottomMapId;
        
        public virtual int LeftMapId
        {
            get
            {
                return mLeftMapId;
            }
            set
            {
                mLeftMapId = value;
            }
        }
        
        private int mLeftMapId;
        
        public virtual int TopMapId
        {
            get
            {
                return mTopMapId;
            }
            set
            {
                mTopMapId = value;
            }
        }
        
        private int mTopMapId;
        
        public MapScrollAction()
        {
        }
    }
}