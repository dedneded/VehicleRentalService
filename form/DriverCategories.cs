using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace form
{
    [Table("DriverCategories")]
    public class DriverCategories
    {
       
        [Column("IdDriver")]
        
        public int DriverId { get; set; }
        [Column("IdDriver")]
        public Driver Driver { get; set; }

        
        [Column("Category")]
        public int Category { get; set; }
        //[Column("Category")]
        //public DrivingCaregories DrivingCaregory { get; set; }

    }
}
