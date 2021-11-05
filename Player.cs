using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public static class Player
    {
        public static void Play(PlayList playList)
        {
            foreach (IPlayble media in playList)
            {
                media.Play();
            }
        }
        public static void Play(MediaFile mediaFile)
        {
            mediaFile.Play();
        }
    }
}