using AJAX.BL.Interfaces;
using AJAX.BL.ModelsBl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AJAX.DAL.Repositories
{
    public class EFCoreRepositoryGetShop : IRepositoryGetShop
    {
        public ICollection<ShopBL> GetAllShop()
        {
            ICollection<ShopBL> shopsresult;

            using (var contex = new DataContext())
            {
                shopsresult = contex.Shops.Select(x => x.ToShopModel()).ToList();
            }

            return shopsresult;
        }

        public ShopBL GetShopById(int? id)
        {
            if (id == null)
                throw new NullReferenceException();

            ShopBL shopById;

            using (var context = new DataContext())
            {
                shopById = context.Shops.Where(x => x.Id == id).FirstOrDefault().ToShopModel();
            }

            return shopById;
        }
    }
}
