using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDB
{
    partial class Category
    {
        public static Category SuaCategory;
        public Category(int categoryID, string categoryName, string description, Binary picture)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }
    }
}
