using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public class MediaCollection
    {
        public List<MediaFile> AllMediaFils;

        public void Add(MediaFile file)
        {
            AllMediaFils.Add(file);
        }

        public void Remove(MediaFile file)
        {
            AllMediaFils.Remove(file);
        }
    }
}