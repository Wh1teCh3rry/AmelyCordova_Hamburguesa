using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmelyCordova_Hamburguesa.Models
{
    [Table("burger")]
    public class AC_Burger
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string ACName { get; set; }
        public string ACDescription { get; set; }
        public bool ACWithExtraCheese { get; set; }
    }
}
