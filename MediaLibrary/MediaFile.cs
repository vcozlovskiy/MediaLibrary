using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLib
{
    public abstract class MediaFile : IPlayble
    {
        protected string filePath;
        protected string fileName;

        public virtual void Play()
        {
            Console.WriteLine($"Проигрывание {this.GetType()}");
        }

        public void ShowProperty()
        {
            Console.WriteLine($"File name: {this.fileName}, File path: {this.filePath}");
        }
    }
}