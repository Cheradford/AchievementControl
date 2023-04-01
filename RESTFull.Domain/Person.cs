using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFull.Domain
{
    [Table("Person")]
    public class Person
    {
        public int Personid { get; set; }
        public string? Passport { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string? patronymic { get; set; }
        public List<Achievement> Achievement { get; set; } = new List<Achievement>();
    }

}
