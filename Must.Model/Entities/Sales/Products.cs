using MF.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Must.Model.Entities.Sales
{
    public class Products : IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public Decimal UnitPrice { get; set; }

        //Navigation property
        public Categories Category { get; set; }
    }
}
