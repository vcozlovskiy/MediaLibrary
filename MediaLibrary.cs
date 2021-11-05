using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public class MediaLibrary
    {
        public MediaCollection MediaCollection;
        public PlayListCollection PlayListCollection;

        public MediaLibrary()
        {
            PlayListCollection = new PlayListCollection();
            MediaCollection = new MediaCollection();
        }
            
        public void PlayPlayList(PlayList playList)
        {
            Player.Play(playList);
        }

        public MediaFile[] Find(string nameMediaFile)
        {
            throw new NotImplementedException();
        }
    }
}