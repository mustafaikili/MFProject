using Must.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Business.Abstruct
{
    public interface IProductService
    {
        void Add(Products product);
        void Delete (Products product);
        void Update(Products product);
        Products Get(int? item);
        ICollection<Products> GetAll(int? item);
    }
}
