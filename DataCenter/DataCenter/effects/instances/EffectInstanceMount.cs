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
    public class EffectInstanceMount : EffectInstance, IData
    {
        
        public virtual double Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }
        
        private double mDate;
        
        public virtual uint ModelId
        {
            get
            {
                return mModelId;
            }
            set
            {
                mModelId = value;
            }
        }
        
        private uint mModelId;
        
        public virtual uint MountId
        {
            get
            {
                return mMountId;
            }
            set
            {
                mMountId = value;
            }
        }
        
        private uint mMountId;
        
        public EffectInstanceMount()
        {
        }
    }
}
