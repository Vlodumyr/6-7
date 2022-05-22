using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UOWTEST : IUOW
    {
        public Dictionary<string, string> CreateOrder(Dictionary<string, string> order)
        {
            var dict = new Dictionary<String, String>();
            dict.Add("Id", "0");
            dict.Add("Name", "Борщ");
            dict.Add("OrderId", "0");
            return dict;
        }

        public void DeleteOrder(Dictionary<string, string> order)
        {
            return;
        }

        public bool Exists(string name)
        {
            return true;
        }

        public Dictionary<string, string>[] GetSeasonDishes()
        {
            var lst = new List<Dictionary<String, String>>();
            var dict = new Dictionary<String, String>();
            dict.Add("Id", "0");
            dict.Add("Name", "Борщ");
            dict.Add("OrderId", "0");
            lst.Add(dict);
            lst.Add(dict);
            lst.Add(dict);
            return lst.ToArray();
        }

        public Dictionary<string, string>[] GetTypeDishes()
        {
            var lst = new List<Dictionary<String, String>>();
            var dict = new Dictionary<String, String>();
            dict.Add("Id", "0");
            dict.Add("Name", "Борщ");
            dict.Add("OrderId", "0");
            lst.Add(dict);
            lst.Add(dict);
            lst.Add(dict);
            return lst.ToArray();
        }

        public bool Order(string name, int orderid)
        {
            return true;
        }
    }
}
