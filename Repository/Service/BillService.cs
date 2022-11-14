using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Repo;

namespace Repository.Service {
    public class BillService {
        BillRepository repository;
        public BillService() {
            repository = new BillRepository();
        }
        public List<Bill> GetAll() {
            return repository.GetAll().ToList();
        }
        public void Create(Bill obj) {
            repository.Create(obj);
        }
        public void Update(Bill obj) {
            repository.Update(obj);
        }
        public void Delete(Bill obj) {
            repository.Delete(obj);
        }
    }
}
