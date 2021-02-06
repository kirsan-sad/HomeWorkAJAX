using AJAX.BL.ModelsBl;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJAX.BL.Interfaces
{
    public interface IRepositoryGetShop
    {
        ICollection<ShopBL> GetAllShop();
    }
}
