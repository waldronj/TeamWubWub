using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamWubWub.Models
{
    using System;
    using System.Collections.Generic;

    public partial class DroppedBass
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
