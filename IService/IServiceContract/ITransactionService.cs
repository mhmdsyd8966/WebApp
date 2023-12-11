﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.IServiceContract
{
    public interface ITransactionService
    {
        public void AddTransaction(Transaction transaction);
        public void RemoveTransaction(int  transactionId);
        public List<Transaction> GetAllTransactions();
        public Transaction GetTransaction(int transactionId);
        public void Save(List<Product>products, string PrdouctId, List<Product> soldQty, double ToTalPrice);
        //public List<Transaction> Search(DateTime startDate,DateTime endDate,int personId);
        public List<Transaction> Search(DateTime startDate, DateTime endDate);
    }
}
