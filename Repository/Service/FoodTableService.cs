using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Repo;

namespace Repository.Service {
    public class FoodTableService {
        FoodTableRepository repository;
        public FoodTableService() {
            repository = new FoodTableRepository();
        }
        public List<FoodTable> GetAll() {
            return repository.GetAll().ToList();
        }
        public void Create(FoodTable obj) {
            repository.Create(obj);
        }
        public void Update(FoodTable obj) {
            repository.Update(obj);
        }
        public void Delete(FoodTable obj) {
            repository.Delete(obj);
        }
    }
}
