using Supermarket.Domain.Models;
using Supermarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> ListAsync()
        {
        }
    }
}
