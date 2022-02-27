using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    [Table("DiscountServices")]
    class DiscountServices
    {
        [Column("IdDiscount")]
        public int DiscountId { get; set; }
        [Column("IdDiscount")]
        public Discount Discount { get; set; }

        [Column("IdService")]
        public int ServiceId { get; set; }
        [Column("IdService")]
        public Service Service { get; set; }
    }
}
