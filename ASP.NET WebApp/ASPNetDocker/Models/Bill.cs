using System;

namespace ASPNetDocker.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }
    }
}
