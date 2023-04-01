using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.Domain
{
    //[Table("IntellectualContests")]
    public class IntellectualContests : Achievement
    {
        public string Title { get; set; }
        public string Form { get; set; }
    }
}
