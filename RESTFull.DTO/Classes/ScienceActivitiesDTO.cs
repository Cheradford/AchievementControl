using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.DTO
{
    //[Table("ScienceActivities")]
    public class ScienceActivitiesDTO : AchievementDTO
    {
        public string Type { get; set; }
    }
}
