using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Food
    {
        public Food()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int IdCategory { get; set; }
        public double Price { get; set; }

        public virtual FoodCategory IdCategoryNavigation { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
