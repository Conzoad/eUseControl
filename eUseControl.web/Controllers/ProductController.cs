using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Entityes.Product;

namespace eUseControl.Web.Controllers
{
    public class ProductController : Controller
    {

        internal IProduct _product;
        internal IAdministration _administration;
        public ProductController()
        {
            var bl = new BussinesLogic.BussinesLogic();
            _product = bl.GetProductBL();
            _administration = bl.GetAdministrationBL();
        }

        // GET: Product
        public ActionResult Index()
        {

            ProductDataModel products = _product.GetProductsToList();

            var model = new
            {
                products
            };


            return View(model);
        }

        public ActionResult Details(int id)
        {

            ProductDataModel singleProduct = _product.GetSingleProduct(id);

            var model = new
            {
                singleProduct
            };

            return View(model);
        }

        public ActionResult Edit(int id)
        {

            var ss =_administration.

            return View();
        }
    }
}