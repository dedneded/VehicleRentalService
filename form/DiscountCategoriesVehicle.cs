using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    [Table("DiscountCategoriesVehicle")]
    class DiscountCategoriesVehicle
    {
        [Column("IdDiscount")]
        public int DiscountId { get; set; }
        [Column("IdDiscount")]
        public Discount Discount { get; set; }

        [Column("IdCategoryOfVehicle")] 
        public int IdCategory { get; set; }
        [Column("IdCategoryOfVehicle")]
        public CategoryOfVehicle CategoryOfVehicle { get; set; }
    }
}
