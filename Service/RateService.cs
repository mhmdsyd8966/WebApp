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
            throw new NotImplementedException();
        }

        public List<Rate> GetRateListByProductId(int ProductId)
        {
            throw new NotImplementedException();
        }

        public void RemoveRate(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRate(Rate rate)
        {
            throw new NotImplementedException();
        }
    }
}
