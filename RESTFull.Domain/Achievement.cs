using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RESTFull.Domain
{
    public class Achievement
    {
        public int id { get; set; }
        public string Achievements { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string? Link { get; set; }

        [JsonIgnore]
        public Person Person { get; set; }
    }

}
