using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroupApp
{
    [Table("Conference")]
    public class Conference
    {
        [PrimaryKey, AutoIncrement, Column("conferenceID")]
        public int conferenceID { get; set; }
        [Indexed]
        [Column("staffID")]
        public int staffID { get; set; }
        public string conference_name { get; set; }
        public string data { get; set; }
        public string venue { get; set; }
    }
}
