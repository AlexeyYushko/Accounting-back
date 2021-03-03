using ASPNetDocker.Models;
using System.Threading.Tasks;

namespace ASPNetDocker.Interfaces
{
    public interface IEventManager
    {
        Task<Event> AddEvent(Event ev);
    }
}