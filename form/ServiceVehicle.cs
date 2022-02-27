using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace form
{
    [Table("ServiceVehicles")]
    class ServiceVehicles
    {
        [Column("IdService")]
        public int ServiceId { get; set; }
        [Column("IdService")]
        public Service Service { get; set; }

        [Column("IdVehicle")]
        public int VehicleId { get; set; }
        [Column("IdVehicle")]
        public Vehicle Vehicle { get; set; }


        [Column("IdOrder")]
        public int OrderId { get; set; }
        [Column("IdOrder")]
        public Order Order { get; set; }
    }
}
