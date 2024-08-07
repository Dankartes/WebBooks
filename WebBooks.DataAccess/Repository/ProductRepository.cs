using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebBooks.DataAccess.Data;
using WebBooks.DataAccess.Repository.IRepository;
using WebBooks.Models;

namespace WebBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
            _db.Products.Include(p => p.Category).Include(p => p.CategoryId);
        }

        public void Update(Product product)
        {
            var dbProduct = _db.Products.FirstOrDefault(p => p.Id == product.Id);

            if (dbProduct != null)
            {
                dbProduct.Title = product.Title;
                dbProduct.Description = product.Description;
                dbProduct.ISBN = product.ISBN;
                dbProduct.Author = product.Author;
                dbProduct.ListPrice = product.ListPrice;
                dbProduct.Price = product.Price;
                dbProduct.Price50 = product.Price50;
                dbProduct.Price100 = product.Price100;
                dbProduct.CategoryId = product.CategoryId;
                if (dbProduct.ImageUrl != null)
                    dbProduct.ImageUrl = product.ImageUrl;
            }
        }
    }
}