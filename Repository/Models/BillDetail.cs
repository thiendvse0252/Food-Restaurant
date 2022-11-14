using System;
using System.Collections.Generic;
using System.Data;

#nullable disable

namespace Repository.Models
{
    public partial class BillDetail
    {
        public int BillId { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int Count { get; set; }

        public virtual Bill IdBillNavigation { get; set; }
        public virtual Food IdFoodNavigation { get; set; }
    }
}
