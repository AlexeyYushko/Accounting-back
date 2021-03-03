using System;

namespace ASPNetDocker.Models
{
    public class Event
    {
        public Guid? Id { get; set; }
        public string Type { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
