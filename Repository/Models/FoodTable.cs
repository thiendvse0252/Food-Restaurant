using System;
using System.Collections.Generic;
using System.Data;

#nullable disable

namespace Repository.Models
{
    public partial class FoodTable
    {
        public FoodTable()
        {
            Bills = new HashSet<Bill>();
        }

        public FoodTable(DataRow row) {
            this.Id = (int)row["ID"];
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
