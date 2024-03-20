using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BussinesLogic.Interface;
using eUseControl.Domain.Entityes.Product;

namespace eUseControl.BussinesLogic.MainBL
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
