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
    using System;


    [Serializable()]
    public class Title : IData
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
        
        public virtual uint NameMaleId
        {
            get
            {
                return mNameMaleId;
            }
            set
            {
                mNameMaleId = value;
            }
        }
        
        private uint mNameMaleId;
        
        public virtual uint NameFemaleId
        {
            get
            {
                return mNameFemaleId;
            }
            set
            {
                mNameFemaleId = value;
            }
        }
        
        private uint mNameFemaleId;
        
        public virtual bool Visible
        {
            get
            {
                return mVisible;
            }
            set
            {
                mVisible = value;
            }
        }
        
        private bool mVisible;
        
        public virtual int CategoryId
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
        
        private int mCategoryId;
        
        public Title()
        {
        }
    }
}
