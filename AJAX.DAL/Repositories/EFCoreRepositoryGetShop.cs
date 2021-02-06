using AJAX.BL.Interfaces;
using AJAX.BL.ModelsBl;
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
    }
}
