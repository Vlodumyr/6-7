using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Repository<T> : IDishRepository<T> where T : BaseDish
    {
        private readonly DbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(bool newDB)
        {
            this.context = new DBContext(newDB);
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetDishByID(int Id)
        {
            return entities.SingleOrDefault(s => s.DishId == Id);
        }

        public void InsertDish(T dish)
        {
            if (dish == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(dish);
            context.SaveChanges();
        }

        public void DeleteDish(T dish)
        {
            if (dish == null)
            {
                throw new ArgumentNullException("entity");
            }
            //entities.Remove(dish);
            //context.SaveChanges();

            var result = entities.SingleOrDefault(d => d.DishId == dish.DishId);
            if (result != null)
            {
                result = null;
                context.SaveChanges();
            }
            context.SaveChanges();
        }

        public void UpdateDish(T dish)
        {
            if (dish == null)
            {
                throw new ArgumentNullException("entity");
            }
            var result = entities.SingleOrDefault(d => d.DishId == dish.DishId);
            if (result != null)
            {
                result = dish;
                context.SaveChanges();
            }
            context.SaveChanges(); 
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }

}
