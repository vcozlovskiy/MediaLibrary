using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public class MediaCollection
    {
        public MediaCollection(List<MediaFile> medias)
        {
            _allMediaFils = new List<MediaFile>(medias);
        }
        
        public MediaCollection()
        {
            _allMediaFils = new List<MediaFile>();
        }

        private List<MediaFile> _allMediaFils;
        public List<MediaFile> AllMediaFils
        {
            get;
        }

        public void Add(MediaFile file)
        {
            _allMediaFils.Add(file);
        }

        public void Remove(MediaFile file)
        {
            _allMediaFils.Remove(file);
        }
    }
}