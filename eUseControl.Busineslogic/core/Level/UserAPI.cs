using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entityes.Auth;
using eUseControl.Domain.Entityes.GeneralResponce;
using eUseControl.Domain.Entityes.Product;
using eUseControl.Domain.Entityes.Product.ModelDB;
using eUseControl.Domain.Entityes.User;
using eUseControl.Domain.Entityes.User.DbModel;

namespace eUseControl.Busineslogic.core.Level
{
    public class UserAPI
    {
        internal RResponceData ULASessionCheck(ULoginData data)
        {
            return new RResponceData
            {
                Status = false,
                CurrentUser = new User
                {
                    UserName = "Vasilica"
                }
            };
        }
        internal CoockieDataUs UserCoockieGenerationAlg(User user)
        {
            return new CoockieDataUs
            {
                MaxAge = 1709044385,
                Coockie = "MY UNIQUE ID FOR THIS SESSION"
            };
        }
        internal ProductDataModel ProductActionGetToList()
        {
            var products = new List<Product>();
            return new ProductDataModel { Products = products };
        }
        internal ProductDataModel ProductGetSingleAction(int id)
        {
            var product = new Product();
            return new ProductDataModel { SingleProduct = product };
        }



    }
}
