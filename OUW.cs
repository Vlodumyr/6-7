using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UOW : IUOW
    {
        private Repository<Dish> Dishes;
        private Repository<SeasonDish> SeasonDishes;
        private Repository<TypeDish> TypeDishes;

        public UOW(bool newDB)
        {
            Dishes = new Repository<Dish>(newDB);
            SeasonDishes = new Repository<SeasonDish>(newDB);
            TypeDishes = new Repository<TypeDish>(newDB);
            if (newDB)
            {
                this.Init();
            }
        }

        private void Init()
        {
            this.Dishes.InsertDish(new Dish() { DishId = 1, Name = "Borsch", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 2, Name = "Cake", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 3, Name = "Coffe", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 4, Name = "Potato", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 5, Name = "Cotlet", OrderId = 0 });

            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 0, Name = "Borsch", Price = 25, Details = "Red borsch", Season = "Monday", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTT6eqTmOOkWSp-9LRudpfF5D2uCFI9mOX4fA&usqp=CAU" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 1, Name = "Cake", Price = 15, Details = "Charlotte", Season = "Tuesday", Image = "https://recepty.24tv.ua/resources/photos/recipe/1200x675_DIR/202001/40445c962e2-9485-46f3-a4f8-87c34c2f5233.png?1581929027000" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 2, Name = "Coffe", Price = 10, Details = "Ammericano", Season = "Friday", Image = "https://i.obozrevatel.com/food/recipemain/2019/3/16/coffee-americano.jpg?size=636x424" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 3, Name = "Potato", Price = 20, Details = "Stewed potatoes with meat and mushrooms", Season = "Sunday", Image = "https://img.povar.ru/main/7a/a9/6f/3a/tushenaya_kartoshka_s_myasom_i_gribami-250654.jpg" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 4, Name = "Cotlet", Price = 15, Details = "Kiew cotlets", Season = "Sunday", Image = "https://zira.uz/wp-content/uploads/2018/09/kotleta-po-kievski-2.jpg" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 5, Name = "Cake", Price = 10, Details = "Count ruins", Season = "Sunday", Image = "https://static.1000.menu/img/content/20587/-tort-grafskie-raz-tort-grafskie-razvaliny-so-smetanoi_1495443247_1_max.jpg" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 6, Name = "Potato", Price = 30, Details = "Mashed potatoes with cutlet", Season = "Friday", Image = "https://mnogoigr96.ru/800/600/https/sun9-44.userapi.com/c840737/v840737027/521a2/oWdHSmCuM_g.jpg" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 7, Name = "Coffe", Price = 15, Details = "Late", Season = "Monday", Image = "https://i.obozrevatel.com/food/recipemain/2019/3/16/kofe-latte.jpg?size=636x424" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 8, Name = "Pancake", Price = 20, Details = "Pancake & syrop", Season = "Monday", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWoy-BhnSgQyczsReosLuo2BObYF3Td2v3Sg&usqp=CAU" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 9, Name = "Borsch", Price = 35, Details = "Green borsch", Season = "Monday", Image = "https://sovkusom.ru/wp-content/uploads/recepty/n/nastoyashchiy-ukrainskiy-zelenyi-borshch/thumb-840x440.jpg" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 10, Name = "Coffe", Price = 20, Details = "Late & syrop", Season = "Tuesday", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbVWMz8kZUTOzjOjcLJgb1OTEEB6i3d7_L9Q&usqp=CAU" });

            this.TypeDishes.InsertDish(new TypeDish() { DishId = 0, Name = "Borsch", Price = 25, Details = "Red borsch", Type = "First", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTT6eqTmOOkWSp-9LRudpfF5D2uCFI9mOX4fA&usqp=CAU" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 1, Name = "Cake", Price = 15, Details = "Charlotte", Type = "Desert", Image = "https://recepty.24tv.ua/resources/photos/recipe/1200x675_DIR/202001/40445c962e2-9485-46f3-a4f8-87c34c2f5233.png?1581929027000" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 2, Name = "Coffe", Price = 10, Details = "Ammericano", Type = "Desert", Image = "https://i.obozrevatel.com/food/recipemain/2019/3/16/coffee-americano.jpg?size=636x424" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 3, Name = "Potato", Price = 20, Details = "Stewed potatoes with meat and mushrooms", Type = "Second", Image = "https://img.povar.ru/main/7a/a9/6f/3a/tushenaya_kartoshka_s_myasom_i_gribami-250654.jpg" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 4, Name = "Cotlet", Price = 15, Details = "Kiew cotlets", Type = "Second", Image = "https://zira.uz/wp-content/uploads/2018/09/kotleta-po-kievski-2.jpg" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 5, Name = "Cake", Price = 10, Details = "Count ruins", Type = "Desert", Image = "https://static.1000.menu/img/content/20587/-tort-grafskie-raz-tort-grafskie-razvaliny-so-smetanoi_1495443247_1_max.jpg" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 6, Name = "Potato", Price = 30, Details = "Mashed potatoes with cutlet", Type = "Second", Image = "https://mnogoigr96.ru/800/600/https/sun9-44.userapi.com/c840737/v840737027/521a2/oWdHSmCuM_g.jpg" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 7, Name = "Coffe", Price = 15, Details = "Late", Type = "Desert", Image = "https://i.obozrevatel.com/food/recipemain/2019/3/16/kofe-latte.jpg?size=636x424" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 8, Name = "Pancake", Price = 20, Details = "Pancake & syrop", Type = "Desert", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWoy-BhnSgQyczsReosLuo2BObYF3Td2v3Sg&usqp=CAU" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 9, Name = "Borsch", Price = 35, Details = "Green borsch", Type = "First", Image = "https://sovkusom.ru/wp-content/uploads/recepty/n/nastoyashchiy-ukrainskiy-zelenyi-borshch/thumb-840x440.jpg" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 10, Name = "Coffe", Price = 20, Details = "Late & syrop", Type = "Desert", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbVWMz8kZUTOzjOjcLJgb1OTEEB6i3d7_L9Q&usqp=CAU" });

        }

        /// <summary>
        /// C-create
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public Dictionary<String, String> CreateOrder(Dictionary<String, String> order)
        {
            var d = new Dish();
            d.Restore(order);
            d.DishId = this.getNextId();
            this.Dishes.InsertDish(d);
            return d.Mapping();
        }
        /// <summary>
        /// R-read
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, String>[] GetSeasonDishes()
        {
            var dict = new List<Dictionary<String, String>>();
            foreach (var i in this.SeasonDishes.GetAll())
            {
                dict.Add(i.Mapping());
            }
            return dict.ToArray();
        }

        public Dictionary<String, String>[] GetTypeDishes()
        {
            var dict = new List<Dictionary<String, String>>();
            foreach (var i in this.TypeDishes.GetAll())
            {
                dict.Add(i.Mapping());
            }
            return dict.ToArray();
        }

        public bool Exists(String name)
        {
            foreach (var i in this.Dishes.GetAll())
            {
                if (i.Name == name && i.OrderId == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// U-update
        /// </summary>
        /// <param name="name"></param>
        /// <param name="orderid"></param>
        /// <returns></returns>
        public bool Order(String name, int orderid)
        {
            foreach (var i in this.Dishes.GetAll())
            {
                if (i.Name == name && i.OrderId == 0)
                {
                    var d = i;
                    d.OrderId = orderid;
                    this.Dishes.UpdateDish(d);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// D-delete
        /// </summary>
        /// <param name="order"></param>
        public void DeleteOrder(Dictionary<String, String> order)
        {
            var d = new Dish();
            d.Restore(order);
            this.Dishes.DeleteDish(d);
        }

        private int getNextId()
        {
            var j = 0;
            foreach (var i in this.Dishes.GetAll())
                j = i.DishId;
            return j + 1;
        }
    }
}
