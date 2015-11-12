using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcCms.Entities.BaseModels
{
    public class Block
    {
        public int BlockID { get; set; }
        public string Name { get; set; }
        public virtual List<PageData> PageDatas { get; set; }
        public virtual BlockDetail BlockDetail { get; set; }
    }
}
