using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.DTO
{
    //[Table("Olympiads")]
    public class OlympiadsDTO : AchievementDTO
    {
        public string Theme { get; set; }
        public string Form { get; set; }
    }
}
