using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsLegoShop.Models;

namespace WebFormsLegoShop
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var db = new LegoDBContext();
            IQueryable<Category> categories = db.Categories;
            return categories;
        }
    }
}