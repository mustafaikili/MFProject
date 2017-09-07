using MF.Core.DataAccess.EntityFramework;
using MF.DataAccess.Abstruct;
using Must.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.DataAccess.Concrete.EntityFramework.Sales
{
    public class EFProductDAL : EFEntityRepositoryBase<MFDbContext,Products>,IProductDAL
    {
    }
}
