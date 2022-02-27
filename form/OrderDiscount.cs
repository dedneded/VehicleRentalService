using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    [Table("OrderDiscounts")]
    class OrderDiscounts
    {
        [Column("Id_order")]
        public int OrderId { get; set; }
        [Column("Id_order")]
        public Order Order { get; set; }

        [Column("Id_discount")]
        public int DiscountId { get; set; }
        [Column("Id_discount")]
        public Discount Discount { get; set; }

    }
}
