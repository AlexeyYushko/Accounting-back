using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.Models;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface IEventRepository : IBaseRepository
    {
        Task<Event> AddEvent(Event ev);
    }
}