using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Busineslogic.core.Level;
using eUseControl.Businesslogic.Interface;
using eUseControl.Domain.Entityes.Product;

namespace eUseControl.Businesslogic.mainbl
{
    public class ProductBL : UserAPI, IProduct
    {
        public ProductDataModel GetProductsToList()
        {
            return ProductActionGetToList();
        }

        public ProductDataModel GetSingleProduct(int id)
        {
            return ProductGetSingleAction(id);
        }
    }
}
