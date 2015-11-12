using AspNetMvcCms.Entities;
using AspNetMvcCms.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcCms.DAL
{
    public class CmsContextInitialize: DropCreateDatabaseAlways<CmsContext>
    {
        protected override void Seed(CmsContext context)
        {
            context.PageDatas.Add(new PageData()
                {
                    PageDataID = 1,
                    Name = "Home",
                    Blocks = new List<Block>() 
                    {
                        new Block()
                        {
                            BlockID = 1,
                            Name = "First block",
                            BlockDetail = new BlockDetail()
                            {
                                   Author = "Miroslav Stojakovic",
                                   CreationDate = DateTime.Now.ToShortDateString()
                            }                            
                        }
                    },
                    MenuLinks = new List<MenuLink>()
                    {
                        new MenuLink()
                        {
                            MenuLinkID = 1,
                            Text = "Home",
                            Url = "Home",
                            Selected = false
                        },
                        new MenuLink()
                        {
                            MenuLinkID = 2,
                            Text = "Products",
                            Url = "Products",
                            Selected = false
                        },
                        new MenuLink()
                        {
                            MenuLinkID = 3,
                            Text = "About",
                            Url = "About",
                            Selected = false
                        }
                    }
                }
                );
            context.SaveChanges();
        }
    }
}
