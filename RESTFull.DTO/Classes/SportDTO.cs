using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.DTO
{
    //[Table("Sport")]
    public class SportDTO : AchievementDTO
    {
        public string Type { get; set; }
        public string Category { get; set; }
    }
}
