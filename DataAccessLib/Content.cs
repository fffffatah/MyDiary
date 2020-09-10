using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class Content
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string Priority { get; set; }
    }
}
