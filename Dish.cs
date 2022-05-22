using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Dishes")]
    class Dish : BaseDish, IMap
    {
        public int OrderId { get; set; }

        public Dictionary<String, String> Mapping()
        {
            var d = new Dictionary<String, String>();
            d.Add("Id", this.DishId.ToString());
            d.Add("Name", this.Name);
            d.Add("OrderId", this.OrderId.ToString());
            return d;
        }

        public void Restore(Dictionary<String, String> d)
        {
            this.DishId = int.Parse(d["Id"]);
            this.Name = d["Name"];
            this.OrderId = int.Parse(d["OrderId"]);
        }
    }
}
