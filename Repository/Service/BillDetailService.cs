using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Repo;

namespace Repository.Service {
    public class BillDetailService {
        BillDetailRepository repository;
        public BillDetailService() {
            repository = new BillDetailRepository();
        }
        public List<BillDetail> GetAll() {
            return repository.GetAll().ToList();
        }
        public List<BillDetail> GetListBillDetail(int id) {
            List<BillDetail> listDetail = new List<BillDetail>();
            var data = repository.GetAll().Where(o => o.IdBill.Equals(id)).FirstOrDefault();
            listDetail.Add(data);
            return listDetail;
        }
        public void Create(BillDetail obj) {
            repository.Create(obj);
        }
        public void Update(BillDetail obj) {
            repository.Update(obj);
        }
        public void Delete(BillDetail obj) {
            repository.Delete(obj);
        }
    }
}
