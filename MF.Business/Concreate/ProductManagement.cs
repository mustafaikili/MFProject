using MF.Business.Abstruct;
using MF.DataAccess.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Must.Model.Entities.Sales;
namespace MF.Business.Concreate
{
    public class ProductManagement : IProductService
    {
        private readonly IProductDAL _productDAL;
        public ProductManagement(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void Add(Products product)
        {
            _productDAL.Add(product);
        }

        public void Delete(Products product)
        {
            _productDAL.Delete(product);
        }

        public void Update(Products product)
        {
            _productDAL.Update(product);
        }

        public Products Get(int? item)
        {
            return _productDAL.Get(x=>x.ProductID==item);
        }

        public ICollection<Products> GetAll(int? item)
        {
            return _productDAL.GetAll(x => x.CategoryID == item);
        }
    }
}
