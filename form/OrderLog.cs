using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    class OrderLog
    {
    public int Id{ get; set; }
    public DateTime Date { get; set; }
    public string Event { get; set; }
    public Order order { get; set; }

    }
}
