using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entityes.Product
{
    public class ProductDataModel
    {
        public ModelDB.Product SingleProduct { get; set; }
        public List<ModelDB.Product> Products { get; set; }
    }
}
