using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using System;
using System.Threading.Tasks;

namespace ASPNetDocker.Managers
{
    public class BillManager: IBillManager
    {
        private readonly IBillRepository billRepository;

        public BillManager(IBillRepository billRepository)
        {
            this.billRepository = billRepository;
        }

        public async Task<Bill> GetByUserId(Guid userId)
        {
            return await billRepository.GetByUserId(userId);
        }
    }
}