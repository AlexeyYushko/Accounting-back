using System;

namespace ASPNetDocker.Models
{
    public class ExchangeRate
    {
        public Guid Id { get; set; } 
        public DateTime Date { get; set; }
        public Currency From { get; set; }
        public Currency To { get; set; }
        public double Rate { get; set; }
    }
}
