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
    public class CreatureBoneOverride : IData
    {
        
        public virtual int BoneId
        {
            get
            {
                return mBoneId;
            }
            set
            {
                mBoneId = value;
            }
        }
        
        private int mBoneId;
        
        public virtual int CreatureBoneId
        {
            get
            {
                return mCreatureBoneId;
            }
            set
            {
                mCreatureBoneId = value;
            }
        }
        
        private int mCreatureBoneId;
        
        public CreatureBoneOverride()
        {
        }
    }
}
