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
    public class EffectInstanceMinMax : EffectInstance, IData
    {
        
        public virtual uint Min
        {
            get
            {
                return mMin;
            }
            set
            {
                mMin = value;
            }
        }
        
        private uint mMin;
        
        public virtual uint Max
        {
            get
            {
                return mMax;
            }
            set
            {
                mMax = value;
            }
        }
        
        private uint mMax;
        
        public EffectInstanceMinMax()
        {
        }
    }
}
