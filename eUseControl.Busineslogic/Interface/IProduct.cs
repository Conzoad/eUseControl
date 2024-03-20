using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entityes.Product;


namespace eUseControl.Busineslogic.IAdministration
{
    internal interface IProduct
    {
        ProductDataModel GetProductsToList();
        ProductDataModel GetSingleProduct(int id);
    }
}
