using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Repo;

namespace Repository.Service {
    public class CategoryService {
        CategoryRepository repository;
        public CategoryService() {
            repository = new CategoryRepository();
        }
        public List<FoodCategory> GetAll() {
            return repository.GetAll().ToList();
        }
        public void Create(FoodCategory obj) {
            repository.Create(obj);
        }
        public void Update(FoodCategory obj) {
            repository.Update(obj);
        }
        public void Delete(FoodCategory obj) {
            repository.Delete(obj);
        }
    }
}
