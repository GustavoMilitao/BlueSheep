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
    public class BonusCriterion : IData
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
        
        public virtual uint Type
        {
            get
            {
                return mType;
            }
            set
            {
                mType = value;
            }
        }
        
        private uint mType;
        
        public virtual int Value
        {
            get
            {
                return mValue;
            }
            set
            {
                mValue = value;
            }
        }
        
        private int mValue;
        
        public BonusCriterion()
        {
        }
    }
}
