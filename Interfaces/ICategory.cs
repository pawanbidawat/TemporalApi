using TemporalBoxApi.Models;

namespace TemporalBoxApi.Interfaces
{
    public interface ICategory
    {
        public List<Categories> GetCategorieDetails();
        public Categories GetCategory(int id);
        public Categories AddCategory(Categories category);
        public Categories UpdatCategorye(Categories category);
        public bool DeleteCategory(int id);
    }
}
