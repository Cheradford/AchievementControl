using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.DTO
{
    public class AchievementDTO
    {
        public int id { get; set; }
        public string Achievements { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Link { get; set; }
    }

}
