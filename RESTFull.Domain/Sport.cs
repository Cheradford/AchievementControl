using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.Domain
{
    //[Table("Sport")]
    public class Sport : Achievement
    {
        public string Type { get; set; }
        public string Category { get; set; }
    }
}
