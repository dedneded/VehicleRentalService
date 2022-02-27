using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    [Table("OrderServiceInOrders")]
    class OrderServiceInOrders
    {
        [Column("ID_serviceInOrder")]
        public int ServiceInOrderId { get; set; }
        [Column("ID_serviceInOrder")]
        public ServiceInOrder ServiceInOrder { get; set; }

        [Column("ID_order")]
        public int OrderId { get; set; }
        [Column("ID_order")]
        public Order Order { get; set; }
    }
}
