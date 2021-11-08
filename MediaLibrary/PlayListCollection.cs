using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public class PlayListCollection
    {
        public PlayListCollection(List<PlayList> medias)
        {
            _playLists = new List<PlayList>(medias);
        }

        public PlayListCollection()
        {
            _playLists = new List<PlayList>();
        }

        private List<PlayList> _playLists;
        public List<PlayList> PlayLists
        {
            get;
            set;
        }

        public void Add(PlayList playList)
        {
            _playLists.Add(playList);
        }

        public void Remove(PlayList playList)
        {
            _playLists.Remove(playList);
        }
    }
}