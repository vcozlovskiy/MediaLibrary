using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public abstract class MediaFile : IPlayble
    {
        private string filePath;
        private string fileName;

        public virtual void Play()
        {
            Console.WriteLine($"Проигрывание {this.GetType()}");
        }
    }
}