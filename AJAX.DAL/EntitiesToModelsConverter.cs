using AJAX.BL.ModelsBl;
using AJAX.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJAX.DAL
{
    internal static class EntitiesToModelsConverter
    {
        internal static ShopBL ToShopModel(this ShopDAL shopEntity)
        {
            return new ShopBL()
            {
                Index = shopEntity.Id,
                Name = shopEntity.Name,
                Schedule = shopEntity.Schedule,
                Description = shopEntity.Description
            };
        }

    }
}
