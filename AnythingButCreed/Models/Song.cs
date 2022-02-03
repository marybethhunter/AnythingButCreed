using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnythingButCreed.Models
{
    internal class Song
    {
        public Song(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
        public string Name { get; set; }
        public string Artist { get; set; }
    }
}
