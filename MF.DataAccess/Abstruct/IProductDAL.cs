using MF.Core.DataAccess;
using Must.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MF.DataAccess.Abstruct
{
    public interface IProductDAL : IEntityRepository<Products>
    {

    }
}
