using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUOW
    {
        Dictionary<String, String> CreateOrder(Dictionary<String, String> order);
        Dictionary<String, String>[] GetSeasonDishes();
        Dictionary<String, String>[] GetTypeDishes();
        bool Exists(String name);
        bool Order(String name, int orderid);
        void DeleteOrder(Dictionary<String, String> order);
    }
}
