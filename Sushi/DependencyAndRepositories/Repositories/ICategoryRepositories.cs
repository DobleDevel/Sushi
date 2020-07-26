using Sushi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sushi.DependencyAndRepositories.Repositories
{
    public interface ICategoryRepositories
    {
        void AddCategory(string name, string url);
        void RemoveCategory(int id);
        Category GetCategoryById(int id);

        List<Category> GetCategories();

        bool CatalogExists(int id);
    }
    public class CatalogRepository : ICategoryRepositories
    {
        private ApplicationDbContext db;
        public CatalogRepository()
        {
            db = ApplicationDbContext.Create();
        }
        public void AddCatalog(string name, string urlImage)
        {
            using (var trans = db.Database.BeginTransaction())
            {
                if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(urlImage))
                {
                    db.Categories.Add(new Category()
                    {
                        category_name = name,
                        category_image = urlImage
                    });
                    db.SaveChanges();
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
        }

        public void AddCategory(string name, string url)
        {
            throw new System.NotImplementedException();
        }

        public bool CatalogExists(int id)
        {
            if (db.Categories.Find(id) != null)
                return true;
            return false;
        }

        public Category GetCatalogById(int id)
        {
            return db.Categories.Find(id);
        }

        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void RemoveCategory(int id)
        {
            if (CatalogExists(id)) db.Categories.Remove(GetCatalogById(id));
            db.SaveChanges();
        }
    }
}
