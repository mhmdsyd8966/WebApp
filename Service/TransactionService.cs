using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TransactionService : ITransactionService
    {
        private List<Transaction> _transactions;
        public TransactionService() {
            _transactions = new List<Transaction>();
        }
        public void AddTransaction(Transaction transaction)
        {
            if(_transactions != null&&_transactions.Count>0)
            {
                var MaxId = _transactions.Max(x => x.Id);
                transaction.Id = MaxId+1;
            }
            else
                transaction.Id = 1;
            _transactions.Add(transaction);
        }

        public void Save(List<Product> products,string PrdouctId, List<Product> soldQty, double ToTalPrice)
        {
            var transactionId = 0;
            if(_transactions!=null&& _transactions.Count>0)
            {
               var MaxId=_transactions.Max(x => x.Id);
                transactionId= MaxId+1;
            }
            else
            {
                transactionId = 1;
            }
            _transactions.Add(new Transaction {
                Id = transactionId,
                IsDone = false,
                Products=products,
                TotalPrice=ToTalPrice,
                SoldQty=soldQty
               
                
            });
        }

        public List<Transaction> GetAllTransactions()
        {
            return _transactions;
        }

        public Transaction GetTransaction(int transactionId)
        {
           return _transactions.Find(x=>x.Id==transactionId);
        }

        public void RemoveTransaction(int transactionId)
        {
            _transactions.Remove(GetTransaction(transactionId));
        }

        public List<Transaction> Search(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
