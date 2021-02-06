using AJAX.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AJAX.DAL.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            if(context.Shops.Any())
            {
                return;
            }

            var shops = new ShopDAL[]
            {
                new ShopDAL {Name = "eMobile", Schedule = "8:00 - 22:00", Description = "Shop 'eMobile' open 8:00 - 22:00. \n Address: Minsk, Lenina 10/20"},
                new ShopDAL {Name = "Патриот", Schedule = "9:00 - 21:00", Description = "Shop 'Патриот' open 9:00 - 21:00. \n Address: Minsk, Kalatyshkina 10/20"},
                new ShopDAL {Name = "Hot-Line", Schedule = "10:00 - 22:00", Description = "Shop 'Hot-Line' open 10:00 - 22:00. \n Address: Minsk, Kalatyshkina 10/20"},
                new ShopDAL {Name = "MEX", Schedule = "9:00 - 22:00", Description = "Shop 'MEX' open 9:00 - 22:00. \n Address: Minsk, Pyshkina 9/20"},
                new ShopDAL {Name = "Кандаловъ", Schedule = "8:00 - 20:00", Description = "Shop 'Кандаловъ' open 8:00 - 20:00. \n Address: Minsk, Kirova 12/10"}
            };

            foreach (var item in shops)
            {
                context.Shops.Add(item);
            }

            context.SaveChanges();
        }
    }
}
