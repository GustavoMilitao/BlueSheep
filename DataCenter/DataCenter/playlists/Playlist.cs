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
    public class Playlist : IData
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
        
        public virtual int SilenceDuration
        {
            get
            {
                return mSilenceDuration;
            }
            set
            {
                mSilenceDuration = value;
            }
        }
        
        private int mSilenceDuration;
        
        public virtual int Iteration
        {
            get
            {
                return mIteration;
            }
            set
            {
                mIteration = value;
            }
        }
        
        private int mIteration;
        
        public virtual int Type
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
        
        private int mType;
        
        public virtual List<PlaylistSound> Sounds
        {
            get
            {
                return mSounds;
            }
            set
            {
                mSounds = value;
            }
        }
        
        private List<PlaylistSound> mSounds = new List<PlaylistSound>();
        
        public Playlist()
        {
        }
    }
}
