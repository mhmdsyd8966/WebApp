using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RateService : IRateService
    {
        private List<Rate> rates;
        public RateService()
        {
            rates = new List<Rate>()
            {
                new Rate{Id=1,Comment="Comment",ProductId=3,ProductName="IPhone",RateNum=4},
                new Rate{Id=2,Comment="Comment",ProductId=3,ProductName="IPhone",RateNum=2.5},
                new Rate{Id=3,Comment="Comment",ProductId=3,ProductName="IPhone",RateNum=5},
                new Rate{Id=4,Comment="Comment",ProductId=3,ProductName="IPhone",RateNum=3.4},
            };
        }
        public void AddRate(Rate rate)
        {
            if (rates != null && rates.Count > 0)
            {
                var MaxId = rates.Max(x => x.ProductId);
                rate.Id = MaxId+1;
            }
            else
            {
                rate.Id = 1;
            }
            rates.Add(rate);
        }

        public List<Rate> GetRateListByProductId(int ProductId)
        {
            return rates.Where(x=>x.ProductId==ProductId).ToList();
        }
        public Rate GetRateById(int id)
        {
            return rates.Find(x => x.Id == id);
        }

        public void RemoveRate(int id)
        {
            rates.Remove(GetRateById(id));
        }

        public void UpdateRate(Rate rate)
        {
            var RateToUpdate = GetRateById(rate.Id);
            if(RateToUpdate != null)
            {
                RateToUpdate.RateNum= rate.RateNum;
                RateToUpdate.ProductName=rate.ProductName;
                RateToUpdate.ProductId = rate.ProductId;
                RateToUpdate.Comment = rate.Comment;
            }
        }
    }
}
