using System;
using System.Threading.Tasks;
using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.Models;

namespace ASPNetDocker.Interfaces
{
    public interface IBillRepository: IBaseRepository
    {
        Task<Bill> GetByUserId(Guid userId);
        Task<Bill> UpdateBill(Guid id, Bill bill);
    }
}