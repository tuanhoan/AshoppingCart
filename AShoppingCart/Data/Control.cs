using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AShoppingCart.Data
{
    interface IServices
    {
        public List<Cart> LoadData();
        public void AddData(Cart cart);
        public void DeleteData(Cart cart);
        public List<Cart> UpdateData();
    }
    public class Control:IServices
    {
        public List<Cart> LoadData()
        {
            var context = new Context();
            return context.Carts.ToList();
        }
        public void AddData(Cart cart)
        {
            var context = new Context();
            context.Add<Cart>(cart);
            context.SaveChanges();
        }

        public void DeleteData(Cart cart)
        {
            var context = new Context();
            context.Carts.Remove(cart);
            context.SaveChanges();
        } 
        public List<Cart> UpdateData()
        {
            throw new NotImplementedException();
        }
    }
}
