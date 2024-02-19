using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemporalBoxApi.Interfaces;
using TemporalBoxApi.JwtContext;
using TemporalBoxApi.Models;


namespace TemporalBoxApi.Services
{
    public class Category : ICategory
    {
        private readonly Context _context;
        public Category(Context context)
        {
            _context = context;
        }

        public Categories AddCategory([FromBody] Categories category)
        {
            var data = _context.Categories.Add(category);
            _context.SaveChanges();
            return data.Entity;
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                var data = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
               if(data==null)
                {
                    throw new Exception("data not found");
                }
                _context.Categories.Remove(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<Categories> GetCategorieDetails()
        {

        
            var data = _context.Categories.Include(x => x.SubCategoryList).ToList();
            return data;

        }

        public Categories GetCategory(int id)
        {
            if (id != 0 && id != null)
            {
                var data = _context.Categories.Find(id);
                return data;

            }
            else
            {
                return null;
            }

        }

        public Categories UpdatCategorye(Categories category)
        {
            throw new NotImplementedException();
        }
    }
    }
