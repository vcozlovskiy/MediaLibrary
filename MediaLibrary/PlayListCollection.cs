using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public class PlayListCollection
    {
        public List<PlayList> PlayLists;

        public void Add(PlayList playList)
        {
            PlayLists.Add(playList);
        }

        public void Remove(PlayList playList)
        {
            PlayLists.Remove(playList);
        }
    }
}