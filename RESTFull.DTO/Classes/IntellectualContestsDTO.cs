using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.DTO
{
    //[Table("IntellectualContests")]
    public class IntellectualContestsDTO : AchievementDTO
    {
        public string Title { get; set; }
        public string Form { get; set; }
    }
}
