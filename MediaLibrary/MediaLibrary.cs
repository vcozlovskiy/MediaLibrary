using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public class MediaLibrary
    {
        private MediaCollection _mediaCollection;
        private PlayListCollection _playListCollection;


        public MediaCollection MediaCollection1
        {
            get
            {
                return _mediaCollection;
            }
        }

        public PlayListCollection PlayListCollection
        {
            get
            {
                return _playListCollection;
            }
        }

        public MediaLibrary()
        {
            _playListCollection = new PlayListCollection();
            _mediaCollection = new MediaCollection();
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