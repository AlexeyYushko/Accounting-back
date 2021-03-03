using System;
using System.Threading.Tasks;
using ASPNetDocker.Models;

namespace ASPNetDocker.Interfaces
{
    public interface IBillManager
    {
        Task<Bill> GetByUserId(Guid userId);

        Task<Bill> UpdateBill(Guid id, Bill bill);
    }
}