using AspNetMvcCms.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcCms.Entities
{
    public class MenuLink
    {
        public int MenuLinkID { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public bool Selected { get; set; }
        public virtual List<PageData> PageDatas { get; set; }
    }
}
