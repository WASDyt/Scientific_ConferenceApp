using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroupApp
{
    [Table("Staff")]
    public class Staff
    {
        [PrimaryKey, AutoIncrement, Column("staffID")]
        public int staffID { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string topic_report { get; set; }
        public string academic_degree { get; set; }
        public string country { get; set; }
        public string organizations { get; set; }
    }
}
