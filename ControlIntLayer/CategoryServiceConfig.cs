using EF_core_demo.Data;
using EF_core_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.ControlIntLayer
{
    public class CategoryServiceConfig
    {
        // Intailizing appDbContext
        private appDbContext con;
        public CategoryServiceConfig(appDbContext con)
        {
            this.con = con;
        }


        // Adding new BookCategory
        public bool AddCategory(Category category)
        {
            bool checkAuthorExist = con.categories.Contains(category);

            if (!checkAuthorExist)
            {
                con.categories.Add(category);
                con.SaveChanges();
                return true;
            }

            return false;
        }

        // Displaying All Categories
        public List<Category> ShowAllCategories()
        {
            return con.categories.ToList();
        }
    }
}
