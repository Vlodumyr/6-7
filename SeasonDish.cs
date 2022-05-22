using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("SeasonDishes")]
    class SeasonDish : BaseDish, IMap
    {
        public string Details { get; set; }
        public string Season { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }

        public Dictionary<String, String> Mapping()
        {
            var d = new Dictionary<String, String>();
            d.Add("Id", this.DishId.ToString());
            d.Add("Name", this.Name);
            d.Add("Details", this.Details);
            d.Add("Season", this.Season);
            d.Add("Price", this.Price.ToString());
            d.Add("Image", this.Image);
            return d;
        }

        public void Restore(Dictionary<String, String> d)
        {
            this.DishId = int.Parse(d["Id"]);
            this.Name = d["Name"];
            this.Details = d["Details"];
            this.Season = d["Season"];
            this.Price = float.Parse(d["Price"]);
            this.Image = d["Image"];
        }
    }
}