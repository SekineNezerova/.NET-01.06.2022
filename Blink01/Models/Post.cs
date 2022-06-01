using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blink01.Models
{
    public class Post : BaseEntity
    {
        public string Hint { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }



    }
}
