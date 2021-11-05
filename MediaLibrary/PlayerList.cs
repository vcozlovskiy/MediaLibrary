using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public class PlayList : IEnumerable<MediaFile>
    {
        public PlayList(MediaFile[] mediaFiles)
        {
            _playList = new MediaFile[mediaFiles.Length];

            for (int i = 0; i < mediaFiles.Length; i++)
            {
                _playList[i] = mediaFiles[i];
            }
        }

        private MediaFile[] _playList;
        private int poz = -1;

        public void Add(MediaFile[] media)
        {
            throw new NotImplementedException();
        }

        public void Remove(MediaFile[] media)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<MediaFile> GetEnumerator()
        {
            for (int i = poz + 1; i < _playList.Length; i++)
            {
                yield return _playList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}