using MF.Business.Abstruct;
using Must.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MF.WebFormUI
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly IProductService _productService;


        public Default(IProductService productService)
        {
            _productService = productService;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Products product = new Products { ProductName ="Chai", UnitPrice=5};
            _productService.Add(product);
        }
    }
}