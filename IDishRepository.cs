using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDishRepository<T> where T : BaseDish
    {
        IEnumerable<T> GetAll();
        T GetDishByID(int Id);
        void InsertDish(T dish);
        void DeleteDish(T dish);
        void UpdateDish(T dish);
        void Save();
    }
}
