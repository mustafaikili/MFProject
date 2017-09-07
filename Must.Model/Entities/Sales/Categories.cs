using MF.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Must.Model.Entities.Sales
{
    public class Categories: IEntity
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //navigation Property
        public virtual ICollection<Products> Product { get; set; }

    }
}
