using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Repo;

namespace Repository.Service {
    public class AccountService {
        AccountRepository repository;
        public AccountService() {
            repository = new AccountRepository();
        }
        public List<Account> GetAll() {
            return repository.GetAll().ToList();
        }
        public void Create(Account obj) {
            repository.Create(obj);
        }
        public void Update(Account obj) {
            repository.Update(obj);
        }
        public void Delete(Account obj) {
            repository.Delete(obj);
        }
    }
}
