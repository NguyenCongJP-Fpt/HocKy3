using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebDemo.Models
{
    public class SongCategory
    {
        public int SongId { get; set; }
        public string  Song { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
    }
}
