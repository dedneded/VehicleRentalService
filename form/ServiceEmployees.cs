using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    [Table("ServiceEmployees")]
    class ServiceEmployees
    {
        [Column("IdService")]
        public int ServiceId { get; set; }
        [Column("IdService")]
        public Service Service { get; set; }

        [Column("IdEmployee")]
        public int EmployeeId { get; set; }
        [Column("IdEmployee")]
        public Employee Employee { get; set; }

        [Column("IdOrder")]
        public int OrderId { get; set; }
        [Column("IdOrder")]
        public Order Order { get; set; }


    }
}
