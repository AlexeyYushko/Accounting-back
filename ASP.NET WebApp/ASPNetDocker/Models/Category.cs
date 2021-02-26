using System;

namespace ASPNetDocker.Models
{
    public class Category
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
