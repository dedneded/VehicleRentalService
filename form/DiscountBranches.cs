using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    [Table("DiscountBranches")]
   public class DiscountBranches
    {
        [Column("IdDiscount")]
        public int DiscountId { get; set; }
        [Column("IdDiscount")]
        public Discount Discount { get; set; }

        [Column("IdBranch")]
        public int BranchId { get; set; }
        [Column("IdBranch")]
        public Branch Branch { get; set; }
    }
}
