using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miniShop.Models;

namespace miniShop.Services
{
    public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}
