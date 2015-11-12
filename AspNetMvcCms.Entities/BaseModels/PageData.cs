using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcCms.Entities.BaseModels
{
    public class PageData
    {
        public int PageDataID { get; set; }
        public string Name { get; set; }
        public virtual List<Block> Blocks { get; set; }
        public virtual List<MenuLink> MenuLinks { get; set; }
    }
}
