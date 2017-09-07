using MF.Business.Abstruct;
using Must.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MF.WebFormUI2
{
    public partial class index : System.Web.UI.Page
    {
        private readonly IProductService _productService;
        public index(IProductService productService)
        {
            _productService = productService;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ProductName = "Chai";
            _productService.Add(product);
            
        }
    }
}