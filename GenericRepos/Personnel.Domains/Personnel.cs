using System;
using System.Linq;

namespace Personnel.Domains
{
    public class Personnel:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
