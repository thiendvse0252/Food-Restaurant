using System;
using System.Collections.Generic;
using System.Data;

#nullable disable

namespace Repository.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public int BillId { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int IdTable { get; set; }
        public int Status { get; set; }

        public virtual FoodTable IdTableNavigation { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
