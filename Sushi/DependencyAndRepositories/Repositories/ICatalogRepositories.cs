using Sushi.Models;

namespace Sushi.DependencyAndRepositories.Repositories
{
    interface ICatalogRepositories
    {
        void AddCatalog(string name, string url);
        void RemoveCatalog(int id);
        Category GetCatalogById(int id);

        bool CatalogExists(int id);
    }
    public class CatalogRepository : ICatalogRepositories
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

        public void RemoveCatalog(int id)
        {
            if (CatalogExists(id)) db.Categories.Remove(GetCatalogById(id));
            db.SaveChanges();
        }
    }
}
