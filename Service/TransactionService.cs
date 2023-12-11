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
        public void AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void EditTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransaction(int transactionId)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransaction(int transactionId)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> Search(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
