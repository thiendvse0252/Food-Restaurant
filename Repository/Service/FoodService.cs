using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Repo;

namespace Repository.Service {
    public class FoodService {
        FoodRepository repository;
        public FoodService() {
            repository = new FoodRepository();
        }
        public List<Food> GetAll() {
            return repository.GetAll().ToList();
        }
        public void Create(Food obj) {
            repository.Create(obj);
        }
        public void Update(Food obj) {
            repository.Update(obj);
        }
        public void Delete(Food obj) {
            repository.Delete(obj);
        }
    }
}
