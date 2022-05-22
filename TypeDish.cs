using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("TypeDishes")]
    class TypeDish : BaseDish, IMap
    {
        public string Details { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public bool IsFree { get; set; }
        public int OrderId { get; set; }

        public Dictionary<String, String> Mapping()
        {
            var d = new Dictionary<String, String>();
            d.Add("Id", this.DishId.ToString());
            d.Add("Name", this.Name);
            d.Add("Details", this.Details);
            d.Add("Type", this.Type);
            d.Add("Price", this.Price.ToString());
            d.Add("Image", this.Image);
            d.Add("IsFree", this.IsFree.ToString());
            d.Add("OrderId", this.OrderId.ToString());
            return d;
        }

        public void Restore(Dictionary<String, String> d)
        {
            this.DishId = int.Parse(d["Id"]);
            this.Name = d["Name"];
            this.Details = d["Details"];
            this.Type = d["Type"];
            this.Price = float.Parse(d["Price"]);
            this.Image = d["Image"];
            this.IsFree = bool.Parse(d["IsFree"]);
            this.OrderId = int.Parse(d["OrderId"]);
        }
    }
}
