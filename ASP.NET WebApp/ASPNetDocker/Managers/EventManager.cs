using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using System.Threading.Tasks;

namespace ASPNetDocker.Managers
{
    public class EventManager : IEventManager
    {
        private readonly IEventRepository eventRepository;

        public EventManager(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public async Task<Event> AddEvent(Event ev)
        {
            return await eventRepository.AddEvent(ev);
        }
    }
}